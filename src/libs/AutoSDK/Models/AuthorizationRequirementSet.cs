namespace AutoSDK.Models;

public record struct AuthorizationRequirementSet(
    EquatableArray<Authorization> Authorizations)
{
    public bool AllowsAnonymous => Authorizations.IsEmpty;
}
