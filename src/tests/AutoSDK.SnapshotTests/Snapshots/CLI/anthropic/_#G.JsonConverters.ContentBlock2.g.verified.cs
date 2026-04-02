//HintName: G.JsonConverters.ContentBlock2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentBlock2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentBlock2>
    {
        /// <inheritdoc />
        public override global::G.ContentBlock2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockStartEventContentBlockDiscriminator>(ref readerCopy, options);

            global::G.ResponseTextBlock? text = default;
            if (discriminator?.Type == global::G.ContentBlockStartEventContentBlockDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseTextBlock>(ref reader, options);
            }
            global::G.ResponseToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::G.ContentBlockStartEventContentBlockDiscriminatorType.ToolUse)
            {
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseToolUseBlock>(ref reader, options);
            }
            global::G.ResponseThinkingBlock? thinking = default;
            if (discriminator?.Type == global::G.ContentBlockStartEventContentBlockDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseThinkingBlock>(ref reader, options);
            }
            global::G.ResponseRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::G.ContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking)
            {
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseRedactedThinkingBlock>(ref reader, options);
            }

            var __value = new global::G.ContentBlock2(
                discriminator?.Type,
                text,

                toolUse,

                thinking,

                redactedThinking
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentBlock2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.ResponseTextBlock), options);
            }
            else if (value.IsToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeof(global::G.ResponseToolUseBlock), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::G.ResponseThinkingBlock), options);
            }
            else if (value.IsRedactedThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeof(global::G.ResponseRedactedThinkingBlock), options);
            }
        }
    }
}