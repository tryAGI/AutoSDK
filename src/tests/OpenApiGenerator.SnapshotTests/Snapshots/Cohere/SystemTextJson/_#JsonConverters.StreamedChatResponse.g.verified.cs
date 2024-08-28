//HintName: JsonConverters.StreamedChatResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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

            var
            readerCopy = reader;
            global::G.ChatStreamStartEvent? streamStartEvent = default;
            try
            {
                streamStartEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatStreamStartEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatSearchQueriesGenerationEvent? searchQueriesGenerationEvent = default;
            try
            {
                searchQueriesGenerationEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatSearchQueriesGenerationEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatSearchResultsEvent? searchResultsEvent = default;
            try
            {
                searchResultsEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatSearchResultsEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatTextGenerationEvent? textGenerationEvent = default;
            try
            {
                textGenerationEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatTextGenerationEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCitationGenerationEvent? citationGenerationEvent = default;
            try
            {
                citationGenerationEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCitationGenerationEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolCallsGenerationEvent? toolCallsGenerationEvent = default;
            try
            {
                toolCallsGenerationEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolCallsGenerationEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatStreamEndEvent? streamEndEvent = default;
            try
            {
                streamEndEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatStreamEndEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolCallsChunkEvent? toolCallsChunkEvent = default;
            try
            {
                toolCallsChunkEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolCallsChunkEvent>(ref readerCopy, options);
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
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatStreamStartEvent>(ref reader, options);
            }
            else if (searchQueriesGenerationEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatSearchQueriesGenerationEvent>(ref reader, options);
            }
            else if (searchResultsEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatSearchResultsEvent>(ref reader, options);
            }
            else if (textGenerationEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatTextGenerationEvent>(ref reader, options);
            }
            else if (citationGenerationEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCitationGenerationEvent>(ref reader, options);
            }
            else if (toolCallsGenerationEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolCallsGenerationEvent>(ref reader, options);
            }
            else if (streamEndEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatStreamEndEvent>(ref reader, options);
            }
            else if (toolCallsChunkEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolCallsChunkEvent>(ref reader, options);
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

            if (value.IsStreamStartEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamStartEvent, typeof(global::G.ChatStreamStartEvent), options);
            }
            else if (value.IsSearchQueriesGenerationEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchQueriesGenerationEvent, typeof(global::G.ChatSearchQueriesGenerationEvent), options);
            }
            else if (value.IsSearchResultsEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResultsEvent, typeof(global::G.ChatSearchResultsEvent), options);
            }
            else if (value.IsTextGenerationEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGenerationEvent, typeof(global::G.ChatTextGenerationEvent), options);
            }
            else if (value.IsCitationGenerationEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationGenerationEvent, typeof(global::G.ChatCitationGenerationEvent), options);
            }
            else if (value.IsToolCallsGenerationEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallsGenerationEvent, typeof(global::G.ChatToolCallsGenerationEvent), options);
            }
            else if (value.IsStreamEndEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEndEvent, typeof(global::G.ChatStreamEndEvent), options);
            }
            else if (value.IsToolCallsChunkEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallsChunkEvent, typeof(global::G.ChatToolCallsChunkEvent), options);
            }
        }
    }
}