using Fluxor;
using FluxorSample.Api;
using FluxorSample.Data.Counter;
using static FluxorSample.Components.ModifyCount.ModifyCount;

namespace FluxorSample.Components.ModifyCount;

public class ModifyCountEffects
{

    private readonly CounterApi _counterApi;
    
    public ModifyCountEffects(CounterApi counterApi) {
        _counterApi = counterApi;
    }

    [EffectMethod(typeof(CounterIncrementButtonClickedAction))]
    public async Task EffectOfCounterIncrementButtonClickedAction(
        IDispatcher dispatcher
    )
    {
        switch(await _counterApi.IncrementCounter(0.7)) {
            case Result<int>.Success success:
                dispatcher.Dispatch(new CounterUpdatedAction(success.Data));
                break;
            case Result<int>.Error error:
                dispatcher.Dispatch(new CounterUpdateFailedAction(error.Message));
                break;
        }
    }

    [EffectMethod(typeof(CounterDecrementButtonClickedAction))]
    public async Task EffectOfCounterDecrementButtonClickedAction(
        IDispatcher dispatcher
    )
    {
        switch(await _counterApi.DecrementCounter(0.7)) {
            case Result<int>.Success success:
                dispatcher.Dispatch(new CounterUpdatedAction(success.Data));
                break;
            case Result<int>.Error error:
                dispatcher.Dispatch(new CounterUpdateFailedAction(error.Message));
                break;
        }
    }
}