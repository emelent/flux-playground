namespace FluxorSample.Data.Counter;

// public record CounterUpdatedAction(int Value);
// public record CounterUpdateFailedAction(string ErrorMessage);

public record CounterIncrement<K>(
   K ActionKind
) where K : ActionKind;

public record CounterDecrement<K>(
   K ActionKind
) where K : ActionKind;
