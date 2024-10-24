//HintName: JsonConverters.AnnotationsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AnnotationsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AnnotationsItem>
    {
        /// <inheritdoc />
        public override global::G.AnnotationsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentTextObjectTextAnnotationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentTextObjectTextAnnotationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageContentTextObjectTextAnnotationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.MessageContentTextAnnotationsFileCitationObject? messageContentTextFileCitationObject = default;
            if (discriminator?.Type == global::G.MessageContentTextObjectTextAnnotationDiscriminatorType.FileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentTextAnnotationsFileCitationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentTextAnnotationsFileCitationObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageContentTextAnnotationsFileCitationObject)}");
                messageContentTextFileCitationObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageContentTextAnnotationsFilePathObject? messageContentTextFilePathObject = default;
            if (discriminator?.Type == global::G.MessageContentTextObjectTextAnnotationDiscriminatorType.FilePath)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentTextAnnotationsFilePathObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentTextAnnotationsFilePathObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageContentTextAnnotationsFilePathObject)}");
                messageContentTextFilePathObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.AnnotationsItem(
                discriminator?.Type,
                messageContentTextFileCitationObject,
                messageContentTextFilePathObject
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AnnotationsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageContentTextFileCitationObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentTextAnnotationsFileCitationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentTextAnnotationsFileCitationObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageContentTextAnnotationsFileCitationObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageContentTextFileCitationObject, typeInfo);
            }
            else if (value.IsMessageContentTextFilePathObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageContentTextAnnotationsFilePathObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageContentTextAnnotationsFilePathObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageContentTextAnnotationsFilePathObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageContentTextFilePathObject, typeInfo);
            }
        }
    }
}