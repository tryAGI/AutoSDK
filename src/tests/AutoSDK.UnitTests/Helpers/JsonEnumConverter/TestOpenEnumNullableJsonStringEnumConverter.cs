namespace AutoSDK.JsonConverters;

public sealed class TestOpenEnumNullableJsonStringEnumConverter : global::System.Text.Json.Serialization.JsonConverter<TestOpenEnum?>
{
    public override TestOpenEnum? Read(
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
                    return TestOpenEnumExtensions.ToEnum(stringValue);
                }

                break;
            }
            case global::System.Text.Json.JsonTokenType.Null:
            {
                return default(TestOpenEnum?);
            }
            default:
                throw new global::System.ArgumentOutOfRangeException(nameof(reader));
        }

        return default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        TestOpenEnum? value,
        global::System.Text.Json.JsonSerializerOptions options)
    {
        writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

        if (value == null)
        {
            writer.WriteNullValue();
        }
        else
        {
            writer.WriteStringValue(TestOpenEnumExtensions.ToValueString(value.Value));
        }
    }
}
