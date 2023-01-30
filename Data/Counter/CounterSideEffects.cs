namespace FluxorSample.Data.Counter;


public record CounterIncrementFailedAction(
    string ErrorMessage
);

public record CounterIncrementedAction();
public record CounterDecrementedAction();
public record CounterDecrementFailedAction(
    string ErrorMessage
);