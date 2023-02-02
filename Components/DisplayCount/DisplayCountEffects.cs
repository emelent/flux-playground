using Fluxor;
using FluxorSample.Api;
using FluxorSample.Data.Counter;

namespace FluxorSample.Components.DisplayCount;

public class DisplayEffects {
    
    private readonly CounterApi _counterApi;
    
    public DisplayEffects(CounterApi counterApi) {
        _counterApi = counterApi;        
    }

    [EffectMethod(typeof(DisplayCount.DisplayCounterInitializedAction))]
    public async Task EffectOfDisplayCounterInitialized(IDispatcher dispatcher){
        switch(await _counterApi.GetCounter()) {
            case Result<int>.Success success:
                dispatcher.Dispatch(new CounterUpdatedAction(success.Data)); 
                break;

            case Result<int>.Error error:
                dispatcher.Dispatch(new CounterUpdateFailedAction(error.Message));;
                break;
        }
    }
}