//HintName: G.JsonConverters.GeneratedMetadataVariant19.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GeneratedMetadataVariant19JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GeneratedMetadataVariant19>
    {
        /// <inheritdoc />
        public override global::G.GeneratedMetadataVariant19 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.MarkdownChunkGeneratedMetadata? markdown = default;
            if (discriminator?.Type == global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MarkdownChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MarkdownChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MarkdownChunkGeneratedMetadata)}");
                markdown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TextChunkGeneratedMetadata? text = default;
            if (discriminator?.Type == global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextChunkGeneratedMetadata)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PDFChunkGeneratedMetadata? pdf = default;
            if (discriminator?.Type == global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PDFChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PDFChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PDFChunkGeneratedMetadata)}");
                pdf = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CodeChunkGeneratedMetadata? code = default;
            if (discriminator?.Type == global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CodeChunkGeneratedMetadata)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AudioChunkGeneratedMetadata? audio = default;
            if (discriminator?.Type == global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AudioChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AudioChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AudioChunkGeneratedMetadata)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VideoChunkGeneratedMetadata? video = default;
            if (discriminator?.Type == global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VideoChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VideoChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VideoChunkGeneratedMetadata)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageChunkGeneratedMetadata? image = default;
            if (discriminator?.Type == global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageChunkGeneratedMetadata)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.GeneratedMetadataVariant19(
                discriminator?.Type,
                markdown,

                text,

                pdf,

                code,

                audio,

                video,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GeneratedMetadataVariant19 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMarkdown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MarkdownChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MarkdownChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MarkdownChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Markdown!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsPdf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PDFChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PDFChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PDFChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pdf!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AudioChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AudioChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AudioChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VideoChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VideoChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VideoChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
        }
    }
}