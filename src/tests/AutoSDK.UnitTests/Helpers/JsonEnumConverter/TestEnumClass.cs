namespace AutoSDK.JsonConverters;

public sealed partial class TestEnumClass
{
    [global::System.Text.Json.Serialization.JsonPropertyName("status")]
    [global::System.Text.Json.Serialization.JsonConverter(typeof(TestEnumJsonStringEnumConverter))]
    public TestEnum? Status { get; set; }
}