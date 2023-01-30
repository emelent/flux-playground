using Fluxor;

namespace FluxorSample.Data.Counter;

[FeatureState]
public record CounterState(
    int Count,
    string ErrorMessage,
    bool Loading
)
{
    public CounterState(): this(
        Count: 0,
        Loading: false,
        ErrorMessage: string.Empty
    ) {}
}