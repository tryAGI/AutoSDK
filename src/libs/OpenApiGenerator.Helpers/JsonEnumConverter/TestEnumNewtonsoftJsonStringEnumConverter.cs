using System;
using Newtonsoft.Json;

namespace OpenApiGenerator.JsonConverters;

public sealed class TestEnumNewtonsoftJsonStringEnumConverter : Newtonsoft.Json.JsonConverter<TestEnum>
{
    public override void WriteJson(JsonWriter writer, TestEnum value, Newtonsoft.Json.JsonSerializer serializer)
    {
        writer = writer ?? throw new ArgumentNullException(nameof(writer));
        
        writer.WriteValue(value.ToValueString());
    }

    public override TestEnum ReadJson(JsonReader reader, Type objectType, TestEnum existingValue, bool hasExistingValue,
        Newtonsoft.Json.JsonSerializer serializer)
    {
        reader = reader ?? throw new ArgumentNullException(nameof(reader));
        
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
                    return TestEnumExtensions.ToEnum(stringValue) ?? default;
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