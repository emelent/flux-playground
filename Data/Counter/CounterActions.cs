namespace FluxorSample.Data.Counter;

public record CounterIncrement<K>(
   K ActionKind
) where K : ActionKind;

public record CounterDecrement<K>(
   K ActionKind
) where K : ActionKind;
