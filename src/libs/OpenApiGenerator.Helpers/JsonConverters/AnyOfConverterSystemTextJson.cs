using System;
using System.Text.Json;
using AnyOfTypes;

#nullable enable

namespace OpenApiGenerator.JsonConverters;

public class AnyOfConverterSystemTextJson<T1, T2> : System.Text.Json.Serialization.JsonConverter<AnyOf<T1, T2>>
{
    public override AnyOf<T1, T2> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        var readerCopy = reader;
        T1? value1 = default;
        try
        {
            value1 = JsonSerializer.Deserialize<T1>(ref readerCopy)!;
        }
        catch (JsonException)
        {
        }
        
        readerCopy = reader;
        T2? value2 = default;
        try
        {
            value2 = JsonSerializer.Deserialize<T2>(ref readerCopy)!;
        }
        catch (JsonException)
        {
        }
        
        if (value1 == null &&
            value2 == null)
        {
            throw new JsonException($"Invalid JSON format for AnyOf<{typeof(T1).Name}, {typeof(T2).Name}>");
        }

        if (value1 != null)
        {
            value1 = JsonSerializer.Deserialize<T1>(ref reader)!;
        }
        else if (value2 != null)
        {
            value2 = JsonSerializer.Deserialize<T2>(ref reader)!;
        }
        
        return new AnyOf<T1, T2>
        {
            First = value1,
            Second = value2,
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AnyOf<T1, T2> value,
        JsonSerializerOptions options)
    {
        if (value.IsFirst)
        {
            JsonSerializer.Serialize(writer, value.First, value.First!.GetType(), options);
        }
        else if (value.IsSecond)
        {
            JsonSerializer.Serialize(writer, value.Second, value.Second!.GetType(), options);
        }
        else
        {
            throw new JsonException($"Invalid AnyOf<{typeof(T1).Name}, {typeof(T2).Name}> object, all values are null");
        }
    }
}