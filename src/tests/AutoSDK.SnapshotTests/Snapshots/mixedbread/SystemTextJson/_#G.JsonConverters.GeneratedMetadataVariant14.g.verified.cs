//HintName: G.JsonConverters.GeneratedMetadataVariant14.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GeneratedMetadataVariant14JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GeneratedMetadataVariant14>
    {
        /// <inheritdoc />
        public override global::G.GeneratedMetadataVariant14 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VideoUrlInputChunkGeneratedMetadataVariant1Discriminator>(ref readerCopy, options);

            global::G.MarkdownChunkGeneratedMetadata? markdown = default;
            if (discriminator?.Type == global::G.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown)
            {
                markdown = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MarkdownChunkGeneratedMetadata>(ref reader, options);
            }
            global::G.TextChunkGeneratedMetadata? text = default;
            if (discriminator?.Type == global::G.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextChunkGeneratedMetadata>(ref reader, options);
            }
            global::G.PDFChunkGeneratedMetadata? pdf = default;
            if (discriminator?.Type == global::G.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf)
            {
                pdf = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PDFChunkGeneratedMetadata>(ref reader, options);
            }
            global::G.CodeChunkGeneratedMetadata? code = default;
            if (discriminator?.Type == global::G.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeChunkGeneratedMetadata>(ref reader, options);
            }
            global::G.AudioChunkGeneratedMetadata? audio = default;
            if (discriminator?.Type == global::G.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio)
            {
                audio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AudioChunkGeneratedMetadata>(ref reader, options);
            }
            global::G.VideoChunkGeneratedMetadata? video = default;
            if (discriminator?.Type == global::G.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video)
            {
                video = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VideoChunkGeneratedMetadata>(ref reader, options);
            }
            global::G.ImageChunkGeneratedMetadata? image = default;
            if (discriminator?.Type == global::G.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageChunkGeneratedMetadata>(ref reader, options);
            }

            var __value = new global::G.GeneratedMetadataVariant14(
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
            global::G.GeneratedMetadataVariant14 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMarkdown)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Markdown, typeof(global::G.MarkdownChunkGeneratedMetadata), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextChunkGeneratedMetadata), options);
            }
            else if (value.IsPdf)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pdf, typeof(global::G.PDFChunkGeneratedMetadata), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::G.CodeChunkGeneratedMetadata), options);
            }
            else if (value.IsAudio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio, typeof(global::G.AudioChunkGeneratedMetadata), options);
            }
            else if (value.IsVideo)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video, typeof(global::G.VideoChunkGeneratedMetadata), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::G.ImageChunkGeneratedMetadata), options);
            }
        }
    }
}