//HintName: G.JsonConverters.StreamedChatResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class StreamedChatResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StreamedChatResponse>
    {
        /// <inheritdoc />
        public override global::G.StreamedChatResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamedChatResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamedChatResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamedChatResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ChatStreamStartEvent? streamStart = default;
            if (discriminator?.EventType == global::G.StreamedChatResponseDiscriminatorEventType.StreamStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatStreamStartEvent)}");
                streamStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatSearchQueriesGenerationEvent? searchQueriesGeneration = default;
            if (discriminator?.EventType == global::G.StreamedChatResponseDiscriminatorEventType.SearchQueriesGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatSearchQueriesGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatSearchQueriesGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatSearchQueriesGenerationEvent)}");
                searchQueriesGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatSearchResultsEvent? searchResults = default;
            if (discriminator?.EventType == global::G.StreamedChatResponseDiscriminatorEventType.SearchResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatSearchResultsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatSearchResultsEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatSearchResultsEvent)}");
                searchResults = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatTextGenerationEvent? textGeneration = default;
            if (discriminator?.EventType == global::G.StreamedChatResponseDiscriminatorEventType.TextGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatTextGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatTextGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatTextGenerationEvent)}");
                textGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatCitationGenerationEvent? citationGeneration = default;
            if (discriminator?.EventType == global::G.StreamedChatResponseDiscriminatorEventType.CitationGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCitationGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCitationGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatCitationGenerationEvent)}");
                citationGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatToolCallsGenerationEvent? toolCallsGeneration = default;
            if (discriminator?.EventType == global::G.StreamedChatResponseDiscriminatorEventType.ToolCallsGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallsGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallsGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatToolCallsGenerationEvent)}");
                toolCallsGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatStreamEndEvent? streamEnd = default;
            if (discriminator?.EventType == global::G.StreamedChatResponseDiscriminatorEventType.StreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatStreamEndEvent)}");
                streamEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatToolCallsChunkEvent? toolCallsChunk = default;
            if (discriminator?.EventType == global::G.StreamedChatResponseDiscriminatorEventType.ToolCallsChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallsChunkEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallsChunkEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatToolCallsChunkEvent)}");
                toolCallsChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatDebugEvent? debug = default;
            if (discriminator?.EventType == global::G.StreamedChatResponseDiscriminatorEventType.Debug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatDebugEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatDebugEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatDebugEvent)}");
                debug = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.StreamedChatResponse(
                discriminator?.EventType,
                streamStart,
                searchQueriesGeneration,
                searchResults,
                textGeneration,
                citationGeneration,
                toolCallsGeneration,
                streamEnd,
                toolCallsChunk,
                debug
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.StreamedChatResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamStart, typeInfo);
            }
            else if (value.IsSearchQueriesGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatSearchQueriesGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatSearchQueriesGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatSearchQueriesGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchQueriesGeneration, typeInfo);
            }
            else if (value.IsSearchResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatSearchResultsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatSearchResultsEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatSearchResultsEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResults, typeInfo);
            }
            else if (value.IsTextGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatTextGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatTextGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatTextGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGeneration, typeInfo);
            }
            else if (value.IsCitationGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCitationGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCitationGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCitationGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationGeneration, typeInfo);
            }
            else if (value.IsToolCallsGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallsGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallsGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallsGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallsGeneration, typeInfo);
            }
            else if (value.IsStreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEnd, typeInfo);
            }
            else if (value.IsToolCallsChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallsChunkEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallsChunkEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallsChunkEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallsChunk, typeInfo);
            }
            else if (value.IsDebug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatDebugEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatDebugEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatDebugEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Debug, typeInfo);
            }
        }
    }
}