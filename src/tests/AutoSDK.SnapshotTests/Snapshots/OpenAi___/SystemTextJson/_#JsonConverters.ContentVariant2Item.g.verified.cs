//HintName: JsonConverters.ContentVariant2Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentVariant2Item>
    {
        /// <inheritdoc />
        public override global::G.ContentVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMessageRequestContentVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMessageRequestContentVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateMessageRequestContentVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.MessageContentImageFileObject? imageFile = default;
            if (discriminator?.Type == global::G.CreateMessageRequestContentVariant2ItemDiscriminatorType.ImageFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentImageFileObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageContentImageFileObject)}");
                imageFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageContentImageUrlObject? imageUrl = default;
            if (discriminator?.Type == global::G.CreateMessageRequestContentVariant2ItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentImageUrlObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageContentImageUrlObject)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageRequestContentTextObject? text = default;
            if (discriminator?.Type == global::G.CreateMessageRequestContentVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageRequestContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageRequestContentTextObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageRequestContentTextObject)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ContentVariant2Item(
                discriminator?.Type,
                imageFile,
                imageUrl,
                text
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentVariant2Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImageFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentImageFileObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageContentImageFileObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageFile, typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentImageUrlObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageContentImageUrlObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageRequestContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageRequestContentTextObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageRequestContentTextObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
        }
    }
}