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
        Loading = false,
        ErrorMessage = string.Empty
    };

    [ReducerMethod]
    public static CounterState ReduceCounterDecrementedAction(
        CounterState state,
        CounterDecrementedAction action
    ) => state with
    {
        Count = state.Count - 1,
        Loading = false,
        ErrorMessage = string.Empty
    };


    [ReducerMethod]
    public static CounterState ReduceCounterDecrementFailedAction(
        CounterState state,
        CounterDecrementFailedAction action
    ) => state with
    {
        ErrorMessage = action.ErrorMessage,
        Loading = false
    };

    [ReducerMethod]
    public static CounterState ReduceCounterIncrementFailedAction(
        CounterState state,
        CounterIncrementFailedAction action
    ) => state with
    {
        ErrorMessage = action.ErrorMessage,
        Loading = false
    };
}