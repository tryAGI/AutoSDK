//HintName: G.JsonConverters.BetaInputContentBlock.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BetaInputContentBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BetaInputContentBlock>
    {
        /// <inheritdoc />
        public override global::G.BetaInputContentBlock Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaInputContentBlockDiscriminator>(ref readerCopy, options);

            global::G.BetaRequestTextBlock? text = default;
            if (discriminator?.Type == global::G.BetaInputContentBlockDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestTextBlock>(ref reader, options);
            }
            global::G.BetaRequestImageBlock? image = default;
            if (discriminator?.Type == global::G.BetaInputContentBlockDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestImageBlock>(ref reader, options);
            }
            global::G.BetaRequestToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::G.BetaInputContentBlockDiscriminatorType.ToolUse)
            {
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestToolUseBlock>(ref reader, options);
            }
            global::G.BetaRequestToolResultBlock? toolResult = default;
            if (discriminator?.Type == global::G.BetaInputContentBlockDiscriminatorType.ToolResult)
            {
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestToolResultBlock>(ref reader, options);
            }
            global::G.BetaRequestDocumentBlock? document = default;
            if (discriminator?.Type == global::G.BetaInputContentBlockDiscriminatorType.Document)
            {
                document = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestDocumentBlock>(ref reader, options);
            }
            global::G.BetaRequestThinkingBlock? thinking = default;
            if (discriminator?.Type == global::G.BetaInputContentBlockDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestThinkingBlock>(ref reader, options);
            }
            global::G.BetaRequestRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::G.BetaInputContentBlockDiscriminatorType.RedactedThinking)
            {
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestRedactedThinkingBlock>(ref reader, options);
            }

            var __value = new global::G.BetaInputContentBlock(
                discriminator?.Type,
                text,

                image,

                toolUse,

                toolResult,

                document,

                thinking,

                redactedThinking
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BetaInputContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.BetaRequestTextBlock), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::G.BetaRequestImageBlock), options);
            }
            else if (value.IsToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeof(global::G.BetaRequestToolUseBlock), options);
            }
            else if (value.IsToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult, typeof(global::G.BetaRequestToolResultBlock), options);
            }
            else if (value.IsDocument)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeof(global::G.BetaRequestDocumentBlock), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::G.BetaRequestThinkingBlock), options);
            }
            else if (value.IsRedactedThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeof(global::G.BetaRequestRedactedThinkingBlock), options);
            }
        }
    }
}