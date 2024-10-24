//HintName: JsonConverters.ContentItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentItem2>
    {
        /// <inheritdoc />
        public override global::G.ContentItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaObjectDeltaContentItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaObjectDeltaContentItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageDeltaObjectDeltaContentItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.MessageDeltaContentImageFileObject? messageDeltaImageFileObject = default;
            if (discriminator?.Type == global::G.MessageDeltaObjectDeltaContentItemDiscriminatorType.ImageFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentImageFileObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageDeltaContentImageFileObject)}");
                messageDeltaImageFileObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageDeltaContentTextObject? messageDeltaTextObject = default;
            if (discriminator?.Type == global::G.MessageDeltaObjectDeltaContentItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentTextObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageDeltaContentTextObject)}");
                messageDeltaTextObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageDeltaContentRefusalObject? messageDeltaRefusalObject = default;
            if (discriminator?.Type == global::G.MessageDeltaObjectDeltaContentItemDiscriminatorType.Refusal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentRefusalObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentRefusalObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageDeltaContentRefusalObject)}");
                messageDeltaRefusalObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageDeltaContentImageUrlObject? messageDeltaImageUrlObject = default;
            if (discriminator?.Type == global::G.MessageDeltaObjectDeltaContentItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentImageUrlObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageDeltaContentImageUrlObject)}");
                messageDeltaImageUrlObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ContentItem2(
                discriminator?.Type,
                messageDeltaImageFileObject,
                messageDeltaTextObject,
                messageDeltaRefusalObject,
                messageDeltaImageUrlObject
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageDeltaImageFileObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentImageFileObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageDeltaContentImageFileObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDeltaImageFileObject, typeInfo);
            }
            else if (value.IsMessageDeltaTextObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentTextObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageDeltaContentTextObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDeltaTextObject, typeInfo);
            }
            else if (value.IsMessageDeltaRefusalObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentRefusalObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentRefusalObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageDeltaContentRefusalObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDeltaRefusalObject, typeInfo);
            }
            else if (value.IsMessageDeltaImageUrlObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentImageUrlObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageDeltaContentImageUrlObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDeltaImageUrlObject, typeInfo);
            }
        }
    }
}