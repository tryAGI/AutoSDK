//HintName: G.JsonConverters.SourcesItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SourcesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SourcesItem>
    {
        /// <inheritdoc />
        public override global::G.SourcesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StoreQAResultsSourceDiscriminator>(ref readerCopy, options);

            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? text = default;
            if (discriminator?.Type == global::G.StoreQAResultsSourceDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk>(ref reader, options);
            }
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? imageUrl = default;
            if (discriminator?.Type == global::G.StoreQAResultsSourceDiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk>(ref reader, options);
            }
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? audioUrl = default;
            if (discriminator?.Type == global::G.StoreQAResultsSourceDiscriminatorType.AudioUrl)
            {
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk>(ref reader, options);
            }
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? videoUrl = default;
            if (discriminator?.Type == global::G.StoreQAResultsSourceDiscriminatorType.VideoUrl)
            {
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk>(ref reader, options);
            }

            var __value = new global::G.SourcesItem(
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
            global::G.SourcesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk), options);
            }
            else if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk), options);
            }
            else if (value.IsAudioUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl, typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk), options);
            }
            else if (value.IsVideoUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUrl, typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk), options);
            }
        }
    }
}