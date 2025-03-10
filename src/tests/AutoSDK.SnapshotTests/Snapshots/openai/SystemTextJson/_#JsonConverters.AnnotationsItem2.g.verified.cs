﻿//HintName: JsonConverters.AnnotationsItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AnnotationsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AnnotationsItem2>
    {
        /// <inheritdoc />
        public override global::G.AnnotationsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentTextObjectTextAnnotationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentTextObjectTextAnnotationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageDeltaContentTextObjectTextAnnotationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.MessageDeltaContentTextAnnotationsFileCitationObject? fileCitation = default;
            if (discriminator?.Type == global::G.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.FileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentTextAnnotationsFileCitationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentTextAnnotationsFileCitationObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageDeltaContentTextAnnotationsFileCitationObject)}");
                fileCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageDeltaContentTextAnnotationsFilePathObject? filePath = default;
            if (discriminator?.Type == global::G.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.FilePath)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentTextAnnotationsFilePathObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentTextAnnotationsFilePathObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageDeltaContentTextAnnotationsFilePathObject)}");
                filePath = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.AnnotationsItem2(
                discriminator?.Type,
                fileCitation,
                filePath
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AnnotationsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentTextAnnotationsFileCitationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentTextAnnotationsFileCitationObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageDeltaContentTextAnnotationsFileCitationObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileCitation, typeInfo);
            }
            else if (value.IsFilePath)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaContentTextAnnotationsFilePathObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaContentTextAnnotationsFilePathObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageDeltaContentTextAnnotationsFilePathObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilePath, typeInfo);
            }
        }
    }
}