namespace AutoSDK.UnitTests.OneOfDiscriminatorConst;

public class InvocationPending : Invocation
{
    [Newtonsoft.Json.JsonRequired]
    public required string id { get; set; }
}
