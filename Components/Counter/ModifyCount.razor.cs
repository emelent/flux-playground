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
        await Task.Delay(600);
        var random = new Random();
        var isSuccessful = random.Next(1, 11) > 5;
        if(isSuccessful) {
            dispatcher.Dispatch(new CounterIncrementedAction());
        } else {
            dispatcher.Dispatch(new CounterIncrementFailedAction(
                ErrorMessage: "Tough luck, try again... if you dare."
            ));
        }
    }

    [EffectMethod(typeof(CounterDecrementButtonClickedAction))]
    public async Task EffectOfCounterDecrementButtonClickedAction(
        IDispatcher dispatcher
    )
    {
        await Task.Delay(600);

        var random = new Random();
        var isSuccessful = random.Next(1, 11) > 5;
        if(isSuccessful) {
            dispatcher.Dispatch(new CounterDecrementedAction());
        } else {
            dispatcher.Dispatch(new CounterDecrementFailedAction(
                ErrorMessage: "Tough luck, try again... if you dare."
            ));
        }
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