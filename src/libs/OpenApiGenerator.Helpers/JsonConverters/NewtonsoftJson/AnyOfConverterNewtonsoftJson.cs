using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#nullable enable

// ReSharper disable once CheckNamespace
namespace OpenApiGenerator.JsonConverters;

public class AnyOfConverterNewtonsoftJson<T1, T2> : JsonConverter<AnyOf<T1, T2>>
{
    public override AnyOf<T1, T2> ReadJson(
        JsonReader reader,
        Type objectType,
        AnyOf<T1, T2> existingValue,
        bool hasExistingValue,
        JsonSerializer serializer)
    {
        serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        
        // Save the current state of the reader
        var jToken = JToken.Load(reader);
        
        T1? value1 = default;
        var readerCopy = jToken.CreateReader();
        try
        {
            value1 = serializer.Deserialize<T1>(readerCopy)!;
        }
        catch (JsonException)
        {
        }
        
        T2? value2 = default;
        readerCopy = jToken.CreateReader();
        try
        {
            value2 = serializer.Deserialize<T2>(readerCopy)!;
        }
        catch (JsonException)
        {
        }
        
        var result = new AnyOf<T1, T2>(value1, value2);
        if (!result.Validate())
        {
            throw new JsonException($"Invalid JSON format for AnyOf<{typeof(T1).Name}, {typeof(T2).Name}>");
        }

        // if (value1 != null)
        // {
        //     value1 = serializer.Deserialize<T1>(reader)!;
        // }
        // else if (value2 != null)
        // {
        //     value2 = serializer.Deserialize<T2>(reader)!;
        // }
        
        return result;
    }
    
    public override void WriteJson(JsonWriter writer, AnyOf<T1, T2> value, JsonSerializer serializer)
    {
        serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        
        if (!value.Validate())
        {
            throw new JsonException($"Invalid AnyOf<{typeof(T1).Name}, {typeof(T2).Name}> object");
        }
        
        if (value.IsValue1)
        {
            serializer.Serialize(writer, value.Value1, value.Value1!.GetType());
        }
        else if (value.IsValue2)
        {
            serializer.Serialize(writer, value.Value2, value.Value2!.GetType());
        }
    }
}