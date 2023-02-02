namespace FluxorSample.Data.Counter;

public record CounterUpdatedAction(int Value);
public record CounterUpdateFailedAction(string ErrorMessage);