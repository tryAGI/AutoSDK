//HintName: JsonConverters.ChatStreamedResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatStreamedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatStreamedResponse>
    {
        /// <inheritdoc />
        public override global::G.ChatStreamedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamedResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamedResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatStreamedResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.StreamSearchResponse? searchResults = default;
            if (discriminator?.Type == global::G.ChatStreamedResponseDiscriminatorType.SearchResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamSearchResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamSearchResponse)}");
                searchResults = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatInfoResponse? chatInfo = default;
            if (discriminator?.Type == global::G.ChatStreamedResponseDiscriminatorType.ChatInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatInfoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatInfoResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatInfoResponse)}");
                chatInfo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamGenerationChunk? generationChunk = default;
            if (discriminator?.Type == global::G.ChatStreamedResponseDiscriminatorType.GenerationChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamGenerationChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamGenerationChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamGenerationChunk)}");
                generationChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamGenerationEnd? generationEnd = default;
            if (discriminator?.Type == global::G.ChatStreamedResponseDiscriminatorType.GenerationEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamGenerationEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamGenerationEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamGenerationEnd)}");
                generationEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FactualConsistencyScore? factualConsistencyScore = default;
            if (discriminator?.Type == global::G.ChatStreamedResponseDiscriminatorType.FactualConsistencyScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FactualConsistencyScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FactualConsistencyScore> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FactualConsistencyScore)}");
                factualConsistencyScore = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamResponseEnd? end = default;
            if (discriminator?.Type == global::G.ChatStreamedResponseDiscriminatorType.End)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamResponseEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamResponseEnd)}");
                end = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerationInfo? generationInfo = default;
            if (discriminator?.Type == global::G.ChatStreamedResponseDiscriminatorType.GenerationInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerationInfo)}");
                generationInfo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamError? error = default;
            if (discriminator?.Type == global::G.ChatStreamedResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ChatStreamedResponse(
                discriminator?.Type,
                searchResults,
                chatInfo,
                generationChunk,
                generationEnd,
                factualConsistencyScore,
                end,
                generationInfo,
                error
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatStreamedResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSearchResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamSearchResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamSearchResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResults, typeInfo);
            }
            else if (value.IsChatInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatInfoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatInfoResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatInfoResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatInfo, typeInfo);
            }
            else if (value.IsGenerationChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamGenerationChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamGenerationChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamGenerationChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerationChunk, typeInfo);
            }
            else if (value.IsGenerationEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamGenerationEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamGenerationEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamGenerationEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerationEnd, typeInfo);
            }
            else if (value.IsFactualConsistencyScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FactualConsistencyScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FactualConsistencyScore?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FactualConsistencyScore).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FactualConsistencyScore, typeInfo);
            }
            else if (value.IsEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamResponseEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamResponseEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeInfo);
            }
            else if (value.IsGenerationInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationInfo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationInfo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerationInfo, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
        }
    }
}