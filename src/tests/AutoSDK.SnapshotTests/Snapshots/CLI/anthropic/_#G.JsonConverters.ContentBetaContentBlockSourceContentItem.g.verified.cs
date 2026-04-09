//HintName: G.JsonConverters.ContentBetaContentBlockSourceContentItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentBetaContentBlockSourceContentItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentBetaContentBlockSourceContentItem>
    {
        /// <inheritdoc />
        public override global::G.ContentBetaContentBlockSourceContentItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BetaRequestTextBlock? text = default;
            if (discriminator?.Type == global::G.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestTextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaRequestTextBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaRequestImageBlock? image = default;
            if (discriminator?.Type == global::G.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestImageBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaRequestImageBlock)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ContentBetaContentBlockSourceContentItem(
                discriminator?.Type,
                text,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentBetaContentBlockSourceContentItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaRequestTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestImageBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaRequestImageBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
        }
    }
}