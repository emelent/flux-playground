using Fluxor;

namespace FluxorSample.Data.Counter;

[FeatureState]
public record CounterState(
    int Count,
    bool Loading
)
{
    public CounterState(): this(Count: 0, Loading: false) {}
}