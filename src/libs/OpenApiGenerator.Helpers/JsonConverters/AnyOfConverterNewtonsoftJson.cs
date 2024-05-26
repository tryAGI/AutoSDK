using System;
using AnyOfTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#nullable enable

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
        
        if (value1 == null &&
            value2 == null)
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
        
        return new AnyOf<T1, T2>
        {
            First = value1,
            Second = value2,
        };
    }
    
    public override void WriteJson(JsonWriter writer, AnyOf<T1, T2> value, JsonSerializer serializer)
    {
        serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        
        if (value.IsFirst)
        {
            serializer.Serialize(writer, value.First, value.First!.GetType());
        }
        else if (value.IsSecond)
        {
            serializer.Serialize(writer, value.Second, value.Second!.GetType());
        }
        else
        {
            throw new JsonException($"Invalid AnyOf<{typeof(T1).Name}, {typeof(T2).Name}> object, all values are null");
        }
    }
}