using System;
using Newtonsoft.Json;

namespace OpenApiGenerator.JsonConverters;

public sealed class TestEnumNewtonsoftJsonStringEnumConverter : Newtonsoft.Json.JsonConverter<TestEnum>
{
    public override void WriteJson(JsonWriter writer, TestEnum value, Newtonsoft.Json.JsonSerializer serializer)
    {
        writer.WriteValue(value.ToValueString());
    }

    public override TestEnum ReadJson(JsonReader reader, Type objectType, TestEnum existingValue, bool hasExistingValue,
        Newtonsoft.Json.JsonSerializer serializer)
    {
        if (hasExistingValue)
        {
            return existingValue;
        }
        
        var type = reader.TokenType;

        switch (type)
        {
            case JsonToken.String:
            {
                var stringValue = reader.ReadAsString();
                if (stringValue != null)
                {
                    return TestEnumExtensions.ToEnum(stringValue);
                }
                break;
            }
            case JsonToken.Integer:
            {
                var numValue = reader.ReadAsInt32();
                if (numValue != null)
                {
                    return (TestEnum)numValue.Value;
                }
                
                break;
            }
        }

        return default;
    }
}