namespace AutoSDK.UnitTests.OneOfDiscriminatorConst;

public class InvocationSucceeded : Invocation
{
    [Newtonsoft.Json.JsonRequired]
    public required string id { get; set; }

    public string? output { get; set; }
}
