namespace AutoSDK.UnitTests.OneOf;

public class Cat
{
    [Newtonsoft.Json.JsonRequired]
    public required bool hunts { get; set; }
    [Newtonsoft.Json.JsonRequired]
    public required int age { get; set; }
}