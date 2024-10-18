//HintName: JsonConverters.ContentChunk.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentChunkJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentChunk>
    {
        /// <inheritdoc />
        public override global::G.ContentChunk Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentChunkDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentChunkDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContentChunkDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextChunk? text = default;
            if (discriminator?.Type == global::G.ContentChunkDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextChunk)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageURLChunk? imageURL = default;
            if (discriminator?.Type == global::G.ContentChunkDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageURLChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageURLChunk)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ContentChunk(
                discriminator?.Type,
                text,
                imageURL
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentChunk value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImageURL)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageURLChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageURLChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageURL, typeInfo);
            }
        }
    }
}