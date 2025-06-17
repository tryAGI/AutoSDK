//HintName: G.JsonConverters.EmbedContent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbedContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbedContent>
    {
        /// <inheritdoc />
        public override global::G.EmbedContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbedContentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbedContentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EmbedContentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.EmbedImage? imageUrl = default;
            if (discriminator?.Type == global::G.EmbedContentDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbedImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbedImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EmbedImage)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.EmbedText? text = default;
            if (discriminator?.Type == global::G.EmbedContentDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbedText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbedText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EmbedText)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.EmbedContent(
                discriminator?.Type,
                imageUrl,
                text
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbedContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbedImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbedImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbedImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbedText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbedText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbedText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
        }
    }
}