using Fluxor;

namespace FluxorSample.Data.User;

[FeatureState]
public record UserState(
    string Name
)
{

    public UserState() : this(Name: ""){}
}