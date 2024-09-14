//HintName: JsonConverters.ChatCompletionRequestAssistantMessageContentPart.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestAssistantMessageContentPartJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionRequestAssistantMessageContentPart>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionRequestAssistantMessageContentPart Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ChatCompletionRequestMessageContentPartText? text = default;
            try
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestMessageContentPartText>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionRequestMessageContentPartRefusal? refusal = default;
            try
            {
                refusal = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestMessageContentPartRefusal>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ChatCompletionRequestAssistantMessageContentPart(
                text,
                refusal
                );

            if (text != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestMessageContentPartText>(ref reader, options);
            }
            else if (refusal != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestMessageContentPartRefusal>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionRequestAssistantMessageContentPart value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.ChatCompletionRequestMessageContentPartText), options);
            }
            else if (value.IsRefusal)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Refusal, typeof(global::G.ChatCompletionRequestMessageContentPartRefusal), options);
            }
        }
    }
}