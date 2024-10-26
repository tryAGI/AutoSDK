//HintName: JsonConverters.QueryStreamedResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class QueryStreamedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.QueryStreamedResponse>
    {
        /// <inheritdoc />
        public override global::G.QueryStreamedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryStreamedResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryStreamedResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.QueryStreamedResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.StreamSearchResponse? searchResults = default;
            if (discriminator?.Type == global::G.QueryStreamedResponseDiscriminatorType.SearchResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamSearchResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamSearchResponse)}");
                searchResults = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamGenerationChunk? generationChunk = default;
            if (discriminator?.Type == global::G.QueryStreamedResponseDiscriminatorType.GenerationChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamGenerationChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamGenerationChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamGenerationChunk)}");
                generationChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamGenerationEnd? generationEnd = default;
            if (discriminator?.Type == global::G.QueryStreamedResponseDiscriminatorType.GenerationEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamGenerationEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamGenerationEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamGenerationEnd)}");
                generationEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamResponseEnd? end = default;
            if (discriminator?.Type == global::G.QueryStreamedResponseDiscriminatorType.End)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamResponseEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamResponseEnd)}");
                end = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FactualConsistencyScore? factualConsistencyScore = default;
            if (discriminator?.Type == global::G.QueryStreamedResponseDiscriminatorType.FactualConsistencyScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FactualConsistencyScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FactualConsistencyScore> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FactualConsistencyScore)}");
                factualConsistencyScore = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerationInfo? generationInfo = default;
            if (discriminator?.Type == global::G.QueryStreamedResponseDiscriminatorType.GenerationInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerationInfo)}");
                generationInfo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamError? error = default;
            if (discriminator?.Type == global::G.QueryStreamedResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.QueryStreamedResponse(
                discriminator?.Type,
                searchResults,
                generationChunk,
                generationEnd,
                end,
                factualConsistencyScore,
                generationInfo,
                error
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.QueryStreamedResponse value,
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
            else if (value.IsEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamResponseEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamResponseEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeInfo);
            }
            else if (value.IsFactualConsistencyScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FactualConsistencyScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FactualConsistencyScore?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FactualConsistencyScore).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FactualConsistencyScore, typeInfo);
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