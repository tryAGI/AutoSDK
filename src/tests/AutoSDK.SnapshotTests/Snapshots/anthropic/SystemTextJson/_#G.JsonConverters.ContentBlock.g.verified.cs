//HintName: G.JsonConverters.ContentBlock.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentBlock>
    {
        /// <inheritdoc />
        public override global::G.ContentBlock Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaContentBlockStartEventContentBlockDiscriminator>(ref readerCopy, options);

            global::G.BetaResponseTextBlock? text = default;
            if (discriminator?.Type == global::G.BetaContentBlockStartEventContentBlockDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponseTextBlock>(ref reader, options);
            }
            global::G.BetaResponseToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::G.BetaContentBlockStartEventContentBlockDiscriminatorType.ToolUse)
            {
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponseToolUseBlock>(ref reader, options);
            }
            global::G.BetaResponseThinkingBlock? thinking = default;
            if (discriminator?.Type == global::G.BetaContentBlockStartEventContentBlockDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponseThinkingBlock>(ref reader, options);
            }
            global::G.BetaResponseRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::G.BetaContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking)
            {
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponseRedactedThinkingBlock>(ref reader, options);
            }

            var __value = new global::G.ContentBlock(
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
            global::G.ContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.BetaResponseTextBlock), options);
            }
            else if (value.IsToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeof(global::G.BetaResponseToolUseBlock), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::G.BetaResponseThinkingBlock), options);
            }
            else if (value.IsRedactedThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeof(global::G.BetaResponseRedactedThinkingBlock), options);
            }
        }
    }
}