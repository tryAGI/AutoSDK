//HintName: JsonConverters.ContentItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentItem>
    {
        /// <inheritdoc />
        public override global::G.ContentItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageObjectContentItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageObjectContentItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageObjectContentItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.MessageContentImageFileObject? messageImageFileObject = default;
            if (discriminator?.Type == global::G.MessageObjectContentItemDiscriminatorType.ImageFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentImageFileObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageContentImageFileObject)}");
                messageImageFileObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageContentImageUrlObject? messageImageUrlObject = default;
            if (discriminator?.Type == global::G.MessageObjectContentItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentImageUrlObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageContentImageUrlObject)}");
                messageImageUrlObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageContentTextObject? messageTextObject = default;
            if (discriminator?.Type == global::G.MessageObjectContentItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentTextObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageContentTextObject)}");
                messageTextObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageContentRefusalObject? messageRefusalObject = default;
            if (discriminator?.Type == global::G.MessageObjectContentItemDiscriminatorType.Refusal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentRefusalObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentRefusalObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageContentRefusalObject)}");
                messageRefusalObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ContentItem(
                discriminator?.Type,
                messageImageFileObject,
                messageImageUrlObject,
                messageTextObject,
                messageRefusalObject
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageImageFileObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentImageFileObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageContentImageFileObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageImageFileObject, typeInfo);
            }
            else if (value.IsMessageImageUrlObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentImageUrlObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageContentImageUrlObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageImageUrlObject, typeInfo);
            }
            else if (value.IsMessageTextObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentTextObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageContentTextObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageTextObject, typeInfo);
            }
            else if (value.IsMessageRefusalObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentRefusalObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentRefusalObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageContentRefusalObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageRefusalObject, typeInfo);
            }
        }
    }
}