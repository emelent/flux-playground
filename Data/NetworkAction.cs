namespace FluxorSample.Data;


public abstract record ActionKind;


public record SucceededAction: ActionKind;
public record SucceededAction<T>(T Result): SucceededAction;

public record FailedAction: ActionKind;
public record FailedAction<T>(T Error): FailedAction;

public record RequestedAction: ActionKind;
public record RequestedAction<T>(T Request): RequestedAction;


