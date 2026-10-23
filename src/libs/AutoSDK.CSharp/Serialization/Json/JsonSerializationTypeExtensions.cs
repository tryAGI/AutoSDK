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

    internal static IJsonSerializer GetSerializer(this JsonSerializerType type, bool useCachedMetadata) =>
        useCachedMetadata && type == JsonSerializerType.SystemTextJson
            ? SystemTextJsonSerializer.CachedInstance : type.GetSerializer();

    public static IJsonSerializer GetSerializer(this EmitterSettings settings)
    {
        return settings.UsesNewtonsoftJson()
            ? NewtonsoftJsonSerializer.Instance
            : settings.UseCachedJsonMetadata ? SystemTextJsonSerializer.CachedInstance : SystemTextJsonSerializer.Instance;
    }
}
