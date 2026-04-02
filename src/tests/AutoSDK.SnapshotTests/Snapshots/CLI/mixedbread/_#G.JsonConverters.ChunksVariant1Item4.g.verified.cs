//HintName: G.JsonConverters.ChunksVariant1Item4.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChunksVariant1Item4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChunksVariant1Item4>
    {
        /// <inheritdoc />
        public override global::G.ChunksVariant1Item4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VectorStoreFileChunksVariant1ItemDiscriminator>(ref readerCopy, options);

            global::G.TextInputChunk? text = default;
            if (discriminator?.Type == global::G.VectorStoreFileChunksVariant1ItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextInputChunk>(ref reader, options);
            }
            global::G.ImageUrlInputChunk? imageUrl = default;
            if (discriminator?.Type == global::G.VectorStoreFileChunksVariant1ItemDiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageUrlInputChunk>(ref reader, options);
            }
            global::G.AudioUrlInputChunk? audioUrl = default;
            if (discriminator?.Type == global::G.VectorStoreFileChunksVariant1ItemDiscriminatorType.AudioUrl)
            {
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AudioUrlInputChunk>(ref reader, options);
            }
            global::G.VideoUrlInputChunk? videoUrl = default;
            if (discriminator?.Type == global::G.VectorStoreFileChunksVariant1ItemDiscriminatorType.VideoUrl)
            {
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VideoUrlInputChunk>(ref reader, options);
            }

            var __value = new global::G.ChunksVariant1Item4(
                discriminator?.Type,
                text,

                imageUrl,

                audioUrl,

                videoUrl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChunksVariant1Item4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextInputChunk), options);
            }
            else if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::G.ImageUrlInputChunk), options);
            }
            else if (value.IsAudioUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl, typeof(global::G.AudioUrlInputChunk), options);
            }
            else if (value.IsVideoUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUrl, typeof(global::G.VideoUrlInputChunk), options);
            }
        }
    }
}