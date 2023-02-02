using Fluxor;
using FluxorSample.Data.Counter;

namespace FluxorSample.Components.DisplayCount;

public class DisplayReducers{
    
    [ReducerMethod(typeof(DisplayCount.DisplayCounterInitializedAction))]
    public static CounterState ReduceDisplayCounterInitializedAction(
        CounterState state
    ) => state with {
        Loading = true,
        ErrorMessage = string.Empty
    };
}