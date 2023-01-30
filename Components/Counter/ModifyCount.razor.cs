using Fluxor;
using FluxorSample.Data.Counter;

namespace FluxorSample.Components.Counter;

public partial class ModifyCount
{

    #region Effects
    [EffectMethod(typeof(CounterIncrementButtonClickedAction))]
    public async Task EffectOfCounterIncrementButtonClickedAction(
        IDispatcher dispatcher
    )
    {
        await Task.Delay(1000);
        dispatcher.Dispatch(new CounterIncrementedAction());
    }

    [EffectMethod(typeof(CounterDecrementButtonClickedAction))]
    public async Task EffectOfCounterDecrementButtonClickedAction(
        IDispatcher dispatcher
    )
    {
        await Task.Delay(1000);
        dispatcher.Dispatch(new CounterDecrementedAction());
    }

    #endregion

    #region Reducers

    [ReducerMethod]
    public static CounterState ReduceCounterIncrementButtonClickedAction(
        CounterState state,
        CounterIncrementButtonClickedAction action
    ) => state with
    {
        Loading = true
    };

    [ReducerMethod]
    public static CounterState ReduceCounterDecrementButtonClickedAction(
        CounterState state,
        CounterDecrementButtonClickedAction action
    ) => state with
    {
        Loading = true
    };

    #endregion
}