using Fluxor;

namespace FluxorSample.Data.Counter;

public class CounterReducer
{

    [ReducerMethod]
    public static CounterState ReduceCounterIncrementSucceededAction(
        CounterState state,
        CounterIncrement<SucceededAction<int>> action
    ) => state with
    {
        Count = action.ActionKind.Result,
        Loading = false
    };

    [ReducerMethod(typeof(CounterIncrement<RequestedAction<double>>))]
    public static CounterState ReduceCounterIncrementRequestedAction(
        CounterState state
    ) => state with
    {
        Loading = true,
        ErrorMessage = string.Empty
    };

    [ReducerMethod]
    public static CounterState ReduceCounterIncrementFailedAction(
        CounterState state,
        CounterIncrement<FailedAction<string>> action
    ) => state with
    {
        Loading = false,
        ErrorMessage = action.ActionKind.Error
    };
    
    

    [ReducerMethod]
    public static CounterState ReduceCounterDecrementSucceededAction(
        CounterState state,
        CounterDecrement<SucceededAction<int>> action
    ) => state with
    {
        Count = action.ActionKind.Result,
        Loading = false
    };

    [ReducerMethod(typeof(CounterDecrement<RequestedAction<double>>))]
    public static CounterState ReduceCounterDecrementRequestedAction(
        CounterState state
    ) => state with
    {
        Loading = true,
        ErrorMessage = string.Empty
    };

    [ReducerMethod]
    public static CounterState ReduceCounterDecrementFailedAction(
        CounterState state,
        CounterDecrement<FailedAction<string>> action
    ) => state with
    {
        Loading = false,
        ErrorMessage = action.ActionKind.Error
    };
    
    
}