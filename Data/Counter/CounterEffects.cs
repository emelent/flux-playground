using Fluxor;
using FluxorSample.Api;
using FluxorSample.Components.ModifyCount;

namespace FluxorSample.Data.Counter;

public class CounterEffects
{
    private readonly CounterApi _counterApi;

    public CounterEffects(CounterApi counterApi)
    {
        _counterApi = counterApi;
    }

    [EffectMethod]
    public async Task EffectOfCounterIncrementRequestedAction(
        CounterIncrement<RequestedAction<double>> action,
        IDispatcher dispatcher
    )
    {
        switch (await _counterApi.IncrementCounter(action.ActionKind.Request))
        {
            case Result<int>.Success success:
                dispatcher.Dispatch(new CounterIncrement<SucceededAction<int>>(
                        new SucceededAction<int>(success.Data)
                    )
                );
                break;
            case Result<int>.Error error:
                dispatcher.Dispatch(new CounterIncrement<FailedAction<string>>(
                        new FailedAction<string>(error.Message)
                    )
                );
                break;
        }
    }

    [EffectMethod]
    public async Task EffectOfCounterDecrementRequestedAction(
        CounterDecrement<RequestedAction<double>> action,
        IDispatcher dispatcher
    )
    {
        switch (await _counterApi.DecrementCounter(action.ActionKind.Request))
        {
            case Result<int>.Success success:
                dispatcher.Dispatch(new CounterDecrement<SucceededAction<int>>(
                        new SucceededAction<int>(success.Data)
                    )
                );
                break;
            case Result<int>.Error error:
                dispatcher.Dispatch(new CounterDecrement<FailedAction<string>>(
                        new FailedAction<string>(error.Message)
                    )
                );
                break;
        }
    }
}