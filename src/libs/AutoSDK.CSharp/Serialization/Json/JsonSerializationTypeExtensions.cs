using AutoSDK.Models;

namespace AutoSDK.Serialization.Json;

public static class JsonSerializationTypeExtensions
{
    // Returns the serializer type based on the provided enum value.
    public static IJsonSerializer GetSerializer(this JsonSerializerType type)
    {
        return type switch
        {
            JsonSerializerType.SystemTextJson => SystemTextJsonSerializer.Instance,
            JsonSerializerType.NewtonsoftJson => NewtonsoftJsonSerializer.Instance,
            _ => throw new NotSupportedException($"Serializer type {type} is not supported.")
        };
    }

    public static IJsonSerializer GetSerializer(this EmitterSettings settings)
    {
        return settings.UsesNewtonsoftJson()
            ? NewtonsoftJsonSerializer.Instance
            : SystemTextJsonSerializer.Instance;
    }
}
