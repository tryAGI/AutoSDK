namespace AutoSDK.UnitTests.OneOf;

public class Dog
{
    [Newtonsoft.Json.JsonRequired]
    public required string breed { get; set; }
    [Newtonsoft.Json.JsonRequired]
    public required bool bark { get; set; }
}