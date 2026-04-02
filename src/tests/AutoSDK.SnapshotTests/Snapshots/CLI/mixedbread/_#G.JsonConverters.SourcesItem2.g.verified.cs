//HintName: G.JsonConverters.SourcesItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SourcesItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SourcesItem2>
    {
        /// <inheritdoc />
        public override global::G.SourcesItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VectorStoreQAResultsSourceDiscriminator>(ref readerCopy, options);

            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? text = default;
            if (discriminator?.Type == global::G.VectorStoreQAResultsSourceDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk>(ref reader, options);
            }
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? imageUrl = default;
            if (discriminator?.Type == global::G.VectorStoreQAResultsSourceDiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk>(ref reader, options);
            }
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? audioUrl = default;
            if (discriminator?.Type == global::G.VectorStoreQAResultsSourceDiscriminatorType.AudioUrl)
            {
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk>(ref reader, options);
            }
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? videoUrl = default;
            if (discriminator?.Type == global::G.VectorStoreQAResultsSourceDiscriminatorType.VideoUrl)
            {
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk>(ref reader, options);
            }

            var __value = new global::G.SourcesItem2(
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
            global::G.SourcesItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk), options);
            }
            else if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk), options);
            }
            else if (value.IsAudioUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl, typeof(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk), options);
            }
            else if (value.IsVideoUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUrl, typeof(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk), options);
            }
        }
    }
}