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

            var
            readerCopy = reader;
            global::G.ChatStreamStartEvent? streamStartEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamStartEvent).Name}");
                streamStartEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatSearchQueriesGenerationEvent? searchQueriesGenerationEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatSearchQueriesGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatSearchQueriesGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatSearchQueriesGenerationEvent).Name}");
                searchQueriesGenerationEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatSearchResultsEvent? searchResultsEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatSearchResultsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatSearchResultsEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatSearchResultsEvent).Name}");
                searchResultsEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatTextGenerationEvent? textGenerationEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatTextGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatTextGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatTextGenerationEvent).Name}");
                textGenerationEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCitationGenerationEvent? citationGenerationEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCitationGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCitationGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCitationGenerationEvent).Name}");
                citationGenerationEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolCallsGenerationEvent? toolCallsGenerationEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallsGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallsGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallsGenerationEvent).Name}");
                toolCallsGenerationEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatStreamEndEvent? streamEndEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEndEvent).Name}");
                streamEndEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolCallsChunkEvent? toolCallsChunkEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallsChunkEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallsChunkEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallsChunkEvent).Name}");
                toolCallsChunkEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.StreamedChatResponse(
                streamStartEvent,
                searchQueriesGenerationEvent,
                searchResultsEvent,
                textGenerationEvent,
                citationGenerationEvent,
                toolCallsGenerationEvent,
                streamEndEvent,
                toolCallsChunkEvent
                );

            if (streamStartEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamStartEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (searchQueriesGenerationEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatSearchQueriesGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatSearchQueriesGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatSearchQueriesGenerationEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (searchResultsEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatSearchResultsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatSearchResultsEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatSearchResultsEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textGenerationEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatTextGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatTextGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatTextGenerationEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (citationGenerationEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCitationGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCitationGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCitationGenerationEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (toolCallsGenerationEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallsGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallsGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallsGenerationEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (streamEndEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEndEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (toolCallsChunkEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallsChunkEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallsChunkEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallsChunkEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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

            if (value.IsStreamStartEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamStartEvent, typeInfo);
            }
            else if (value.IsSearchQueriesGenerationEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatSearchQueriesGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatSearchQueriesGenerationEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatSearchQueriesGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchQueriesGenerationEvent, typeInfo);
            }
            else if (value.IsSearchResultsEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatSearchResultsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatSearchResultsEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatSearchResultsEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResultsEvent, typeInfo);
            }
            else if (value.IsTextGenerationEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatTextGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatTextGenerationEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatTextGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGenerationEvent, typeInfo);
            }
            else if (value.IsCitationGenerationEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCitationGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCitationGenerationEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCitationGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationGenerationEvent, typeInfo);
            }
            else if (value.IsToolCallsGenerationEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallsGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallsGenerationEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallsGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallsGenerationEvent, typeInfo);
            }
            else if (value.IsStreamEndEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEndEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEndEvent, typeInfo);
            }
            else if (value.IsToolCallsChunkEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallsChunkEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallsChunkEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallsChunkEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallsChunkEvent, typeInfo);
            }
        }
    }
}