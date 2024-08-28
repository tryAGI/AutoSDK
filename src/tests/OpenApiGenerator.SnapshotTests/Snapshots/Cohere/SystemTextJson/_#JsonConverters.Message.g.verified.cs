//HintName: JsonConverters.Message.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class MessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Message>
    {
        /// <inheritdoc />
        public override global::G.Message Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ChatMessage? chat = default;
            try
            {
                chat = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatMessage>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolMessage? tool = default;
            try
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolMessage>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Message(
                chat,
                tool
                );

            if (chat != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatMessage>(ref reader, options);
            }
            else if (tool != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolMessage>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Message value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChat)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeof(global::G.ChatMessage), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.ToolMessage), options);
            }
        }
    }
}