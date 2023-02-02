using Fluxor;
using FluxorSample.Data.Counter;
using static FluxorSample.Components.ModifyCount.ModifyCount;

namespace FluxorSample.Components.ModifyCount;

public class ModifyCountReducers
{

    [ReducerMethod(typeof(CounterIncrementButtonClickedAction))]
    public static CounterState ReducerCounterIncrementButtonClickedAction(
        CounterState state
    ) => state with
    {
        Loading = true,
        ErrorMessage = string.Empty
    };

    [ReducerMethod(typeof(CounterDecrementButtonClickedAction))]
    public static CounterState ReducerCounterDecrementButtonClickedAction(
        CounterState state
    ) => state with
    {
        Loading = true,
        ErrorMessage = string.Empty
    };
}