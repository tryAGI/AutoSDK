//HintName: JsonConverters.ChatCompletionRequestMessage.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionRequestMessage>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionRequestMessage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ChatCompletionRequestSystemMessage? system = default;
            try
            {
                system = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestSystemMessage>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionRequestUserMessage? user = default;
            try
            {
                user = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestUserMessage>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionRequestAssistantMessage? assistant = default;
            try
            {
                assistant = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestAssistantMessage>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionRequestToolMessage? tool = default;
            try
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestToolMessage>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionRequestFunctionMessage? function = default;
            try
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestFunctionMessage>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::G.ChatCompletionRequestMessage(
                system,

                user,

                assistant,

                tool,

                function
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::G.ChatCompletionRequestSystemMessage).Name}, {typeof(global::G.ChatCompletionRequestUserMessage).Name}, {typeof(global::G.ChatCompletionRequestAssistantMessage).Name}, {typeof(global::G.ChatCompletionRequestToolMessage).Name}, {typeof(global::G.ChatCompletionRequestFunctionMessage).Name}>");
            }

            if (system != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestSystemMessage>(ref reader, options);
            }

            else if (user != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestUserMessage>(ref reader, options);
            }

            else if (assistant != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestAssistantMessage>(ref reader, options);
            }

            else if (tool != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestToolMessage>(ref reader, options);
            }

            else if (function != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestFunctionMessage>(ref reader, options);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionRequestMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::G.ChatCompletionRequestSystemMessage).Name}, {typeof(global::G.ChatCompletionRequestUserMessage).Name}, {typeof(global::G.ChatCompletionRequestAssistantMessage).Name}, {typeof(global::G.ChatCompletionRequestToolMessage).Name}, {typeof(global::G.ChatCompletionRequestFunctionMessage).Name}> object.");
            }

            if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::G.ChatCompletionRequestSystemMessage), options);
            }

            else if (value.IsUser)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeof(global::G.ChatCompletionRequestUserMessage), options);
            }

            else if (value.IsAssistant)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeof(global::G.ChatCompletionRequestAssistantMessage), options);
            }

            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.ChatCompletionRequestToolMessage), options);
            }

            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::G.ChatCompletionRequestFunctionMessage), options);
            }
        }
    }
}