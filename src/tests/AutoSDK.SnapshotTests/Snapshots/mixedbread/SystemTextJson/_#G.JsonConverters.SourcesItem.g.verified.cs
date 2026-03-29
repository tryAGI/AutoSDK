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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StoreQAResultsSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StoreQAResultsSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StoreQAResultsSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? text = default;
            if (discriminator?.Type == global::G.StoreQAResultsSourceDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? imageUrl = default;
            if (discriminator?.Type == global::G.StoreQAResultsSourceDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? audioUrl = default;
            if (discriminator?.Type == global::G.StoreQAResultsSourceDiscriminatorType.AudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk)}");
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? videoUrl = default;
            if (discriminator?.Type == global::G.StoreQAResultsSourceDiscriminatorType.VideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk)}");
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeInfo);
            }
            else if (value.IsAudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl, typeInfo);
            }
            else if (value.IsVideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUrl, typeInfo);
            }
        }
    }
}