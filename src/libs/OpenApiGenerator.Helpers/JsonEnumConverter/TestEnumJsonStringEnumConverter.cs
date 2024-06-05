namespace OpenApiGenerator.JsonConverters;

public sealed class TestEnumJsonStringEnumConverter : global::System.Text.Json.Serialization.JsonConverter<TestEnum>
{
    public override TestEnum Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case global::System.Text.Json.JsonTokenType.String:
            {
                var stringValue = reader.GetString();
                if (stringValue != null)
                {
                    return TestEnumExtensions.ToEnum(stringValue) ?? default;
                }
                
                break;
            }
            case global::System.Text.Json.JsonTokenType.Number:
            {
                return (TestEnum)reader.GetInt32();
            }
            default:
                throw new global::System.ArgumentOutOfRangeException(nameof(reader));
        }

        return default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        TestEnum value,
        global::System.Text.Json.JsonSerializerOptions options)
    {
        writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));
        
        writer.WriteStringValue(value.ToValueString());
    }
}