//HintName: JsonConverters.StreamedChatResponse2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class StreamedChatResponse2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StreamedChatResponse2>
    {
        /// <inheritdoc />
        public override global::G.StreamedChatResponse2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ChatMessageStartEvent? messageStartEvent = default;
            try
            {
                messageStartEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatMessageStartEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatContentStartEvent? contentStartEvent = default;
            try
            {
                contentStartEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatContentStartEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatContentDeltaEvent? contentDeltaEvent = default;
            try
            {
                contentDeltaEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatContentDeltaEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatContentEndEvent? contentEndEvent = default;
            try
            {
                contentEndEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatContentEndEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolPlanDeltaEvent? toolPlanDeltaEvent = default;
            try
            {
                toolPlanDeltaEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolPlanDeltaEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolCallStartEvent? toolCallStartEvent = default;
            try
            {
                toolCallStartEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolCallStartEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolCallDeltaEvent? toolCallDeltaEvent = default;
            try
            {
                toolCallDeltaEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolCallDeltaEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolCallEndEvent? toolCallEndEvent = default;
            try
            {
                toolCallEndEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolCallEndEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatMessageEndEvent? messageEndEvent = default;
            try
            {
                messageEndEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatMessageEndEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.StreamedChatResponse2(
                messageStartEvent,
                contentStartEvent,
                contentDeltaEvent,
                contentEndEvent,
                toolPlanDeltaEvent,
                toolCallStartEvent,
                toolCallDeltaEvent,
                toolCallEndEvent,
                messageEndEvent
                );

            if (messageStartEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatMessageStartEvent>(ref reader, options);
            }
            else if (contentStartEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatContentStartEvent>(ref reader, options);
            }
            else if (contentDeltaEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatContentDeltaEvent>(ref reader, options);
            }
            else if (contentEndEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatContentEndEvent>(ref reader, options);
            }
            else if (toolPlanDeltaEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolPlanDeltaEvent>(ref reader, options);
            }
            else if (toolCallStartEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolCallStartEvent>(ref reader, options);
            }
            else if (toolCallDeltaEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolCallDeltaEvent>(ref reader, options);
            }
            else if (toolCallEndEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolCallEndEvent>(ref reader, options);
            }
            else if (messageEndEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatMessageEndEvent>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.StreamedChatResponse2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessageStartEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStartEvent, typeof(global::G.ChatMessageStartEvent), options);
            }
            else if (value.IsContentStartEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentStartEvent, typeof(global::G.ChatContentStartEvent), options);
            }
            else if (value.IsContentDeltaEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentDeltaEvent, typeof(global::G.ChatContentDeltaEvent), options);
            }
            else if (value.IsContentEndEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentEndEvent, typeof(global::G.ChatContentEndEvent), options);
            }
            else if (value.IsToolPlanDeltaEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolPlanDeltaEvent, typeof(global::G.ChatToolPlanDeltaEvent), options);
            }
            else if (value.IsToolCallStartEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallStartEvent, typeof(global::G.ChatToolCallStartEvent), options);
            }
            else if (value.IsToolCallDeltaEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallDeltaEvent, typeof(global::G.ChatToolCallDeltaEvent), options);
            }
            else if (value.IsToolCallEndEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallEndEvent, typeof(global::G.ChatToolCallEndEvent), options);
            }
            else if (value.IsMessageEndEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageEndEvent, typeof(global::G.ChatMessageEndEvent), options);
            }
        }
    }
}