//HintName: JsonConverters.ChatMessage2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ChatMessage2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatMessage2>
    {
        /// <inheritdoc />
        public override global::G.ChatMessage2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.UserMessage? userMessage = default;
            try
            {
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserMessage>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AssistantMessage? assistantMessage = default;
            try
            {
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantMessage>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.SystemMessage? systemMessage = default;
            try
            {
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SystemMessage>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolMessage2? tool = default;
            try
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolMessage2>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ChatMessage2(
                userMessage,
                assistantMessage,
                systemMessage,
                tool
                );

            if (userMessage != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserMessage>(ref reader, options);
            }
            else if (assistantMessage != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantMessage>(ref reader, options);
            }
            else if (systemMessage != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SystemMessage>(ref reader, options);
            }
            else if (tool != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolMessage2>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatMessage2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUserMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeof(global::G.UserMessage), options);
            }
            else if (value.IsAssistantMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeof(global::G.AssistantMessage), options);
            }
            else if (value.IsSystemMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeof(global::G.SystemMessage), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.ToolMessage2), options);
            }
        }
    }
}