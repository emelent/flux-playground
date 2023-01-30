using Fluxor;

namespace FluxorSample.Data.Counter;

public class CounterReducer
{

    [ReducerMethod]
    public static CounterState ReduceCounterIncrementedAction(
        CounterState state,
        CounterIncrementedAction action
    ) => state with
    {
        Count = state.Count + 1,
        Loading = false
    };

    [ReducerMethod]
    public static CounterState ReduceCounterDecrementedAction(
        CounterState state,
        CounterDecrementedAction action
    ) => state with
    {
        Count = state.Count - 1,
        Loading = false
    };
}