namespace AutoSDK.JsonConverters;

public sealed class TestOpenEnumNullableNewtonsoftJsonStringEnumConverter : global::Newtonsoft.Json.JsonConverter<TestOpenEnum?>
{
    public override void WriteJson(
        global::Newtonsoft.Json.JsonWriter writer,
        TestOpenEnum? value,
        global::Newtonsoft.Json.JsonSerializer serializer)
    {
        writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

        if (value == null)
        {
            writer.WriteNull();
        }
        else
        {
            writer.WriteValue(TestOpenEnumExtensions.ToValueString(value.Value));
        }
    }

    public override TestOpenEnum? ReadJson(
        global::Newtonsoft.Json.JsonReader reader,
        global::System.Type objectType,
        TestOpenEnum? existingValue,
        bool hasExistingValue,
        global::Newtonsoft.Json.JsonSerializer serializer)
    {
        reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

        if (hasExistingValue)
        {
            return existingValue;
        }

        switch (reader.TokenType)
        {
            case global::Newtonsoft.Json.JsonToken.String:
            {
                var stringValue = reader.Value as string ?? reader.ReadAsString();
                if (stringValue != null)
                {
                    return TestOpenEnumExtensions.ToEnum(stringValue);
                }

                break;
            }
            case global::Newtonsoft.Json.JsonToken.Null:
            {
                return default(TestOpenEnum?);
            }
        }

        return default;
    }
}
