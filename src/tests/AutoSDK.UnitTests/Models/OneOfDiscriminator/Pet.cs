namespace AutoSDK.UnitTests.OneOfDiscriminator;

public class Pet
{
    [Newtonsoft.Json.JsonRequired]
    public required string pet_type { get; set; }
}