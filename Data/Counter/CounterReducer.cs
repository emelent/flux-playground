using Fluxor;

namespace FluxorSample.Data.Counter;

public class CounterReducer
{

    [ReducerMethod]
    public static CounterState ReduceCounterIncrementedAction(
        CounterState state,
        CounterUpdatedAction action
    ) => state with
    {
        Count = action.Value,
        Loading = false,
        ErrorMessage = string.Empty
    };


    [ReducerMethod]
    public static CounterState ReduceCounterUpdateFailedAction(
        CounterState state,
        CounterUpdateFailedAction action
    ) => state with
    {
        Loading = false,
        ErrorMessage = action.ErrorMessage
    };
}