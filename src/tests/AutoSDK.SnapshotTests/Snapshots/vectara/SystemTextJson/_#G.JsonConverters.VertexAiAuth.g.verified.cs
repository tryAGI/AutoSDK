//HintName: G.JsonConverters.VertexAiAuth.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class VertexAiAuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.VertexAiAuth>
    {
        /// <inheritdoc />
        public override global::G.VertexAiAuth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexAiAuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexAiAuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VertexAiAuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.VertexAiApiKeyAuth? apiKey = default;
            if (discriminator?.Type == global::G.VertexAiAuthDiscriminatorType.ApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexAiApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexAiApiKeyAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VertexAiApiKeyAuth)}");
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VertexAiServiceAccountAuth? serviceAccount = default;
            if (discriminator?.Type == global::G.VertexAiAuthDiscriminatorType.ServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexAiServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexAiServiceAccountAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VertexAiServiceAccountAuth)}");
                serviceAccount = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.VertexAiAuth(
                discriminator?.Type,
                apiKey,

                serviceAccount
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.VertexAiAuth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexAiApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexAiApiKeyAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VertexAiApiKeyAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey!, typeInfo);
            }
            else if (value.IsServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexAiServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexAiServiceAccountAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VertexAiServiceAccountAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServiceAccount!, typeInfo);
            }
        }
    }
}