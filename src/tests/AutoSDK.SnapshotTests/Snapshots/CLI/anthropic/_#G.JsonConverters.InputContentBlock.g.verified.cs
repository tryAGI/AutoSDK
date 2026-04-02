//HintName: G.JsonConverters.InputContentBlock.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputContentBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputContentBlock>
    {
        /// <inheritdoc />
        public override global::G.InputContentBlock Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputContentBlockDiscriminator>(ref readerCopy, options);

            global::G.RequestTextBlock? text = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestTextBlock>(ref reader, options);
            }
            global::G.RequestImageBlock? image = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestImageBlock>(ref reader, options);
            }
            global::G.RequestToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.ToolUse)
            {
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestToolUseBlock>(ref reader, options);
            }
            global::G.RequestToolResultBlock? toolResult = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.ToolResult)
            {
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestToolResultBlock>(ref reader, options);
            }
            global::G.RequestDocumentBlock? document = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.Document)
            {
                document = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestDocumentBlock>(ref reader, options);
            }
            global::G.RequestThinkingBlock? thinking = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestThinkingBlock>(ref reader, options);
            }
            global::G.RequestRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.RedactedThinking)
            {
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestRedactedThinkingBlock>(ref reader, options);
            }

            var __value = new global::G.InputContentBlock(
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
            global::G.InputContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.RequestTextBlock), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::G.RequestImageBlock), options);
            }
            else if (value.IsToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeof(global::G.RequestToolUseBlock), options);
            }
            else if (value.IsToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult, typeof(global::G.RequestToolResultBlock), options);
            }
            else if (value.IsDocument)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeof(global::G.RequestDocumentBlock), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::G.RequestThinkingBlock), options);
            }
            else if (value.IsRedactedThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeof(global::G.RequestRedactedThinkingBlock), options);
            }
        }
    }
}