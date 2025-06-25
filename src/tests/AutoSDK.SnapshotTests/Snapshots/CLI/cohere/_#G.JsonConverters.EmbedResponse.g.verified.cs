//HintName: G.JsonConverters.EmbedResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbedResponse>
    {
        /// <inheritdoc />
        public override global::G.EmbedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbedResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbedResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EmbedResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.EmbedFloatsResponse? embeddingsFloats = default;
            if (discriminator?.ResponseType == global::G.EmbedResponseDiscriminatorResponseType.EmbeddingsFloats)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbedFloatsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbedFloatsResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EmbedFloatsResponse)}");
                embeddingsFloats = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.EmbedByTypeResponse? embeddingsByType = default;
            if (discriminator?.ResponseType == global::G.EmbedResponseDiscriminatorResponseType.EmbeddingsByType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbedByTypeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbedByTypeResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EmbedByTypeResponse)}");
                embeddingsByType = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.EmbedResponse(
                discriminator?.ResponseType,
                embeddingsFloats,
                embeddingsByType
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbedResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEmbeddingsFloats)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbedFloatsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbedFloatsResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbedFloatsResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsFloats, typeInfo);
            }
            else if (value.IsEmbeddingsByType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbedByTypeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbedByTypeResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbedByTypeResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsByType, typeInfo);
            }
        }
    }
}