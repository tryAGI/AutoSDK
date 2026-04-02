//HintName: G.JsonConverters.LettaMessageContentUnion.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class LettaMessageContentUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LettaMessageContentUnion>
    {
        /// <inheritdoc />
        public override global::G.LettaMessageContentUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaMessageContentUnionDiscriminator>(ref readerCopy, options);

            global::G.TextContent? text = default;
            if (discriminator?.Type == global::G.LettaMessageContentUnionDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextContent>(ref reader, options);
            }
            global::G.ImageContent? image = default;
            if (discriminator?.Type == global::G.LettaMessageContentUnionDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageContent>(ref reader, options);
            }
            global::G.ToolCallContent? toolCall = default;
            if (discriminator?.Type == global::G.LettaMessageContentUnionDiscriminatorType.ToolCall)
            {
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolCallContent>(ref reader, options);
            }
            global::G.ToolReturnContent? toolReturn = default;
            if (discriminator?.Type == global::G.LettaMessageContentUnionDiscriminatorType.ToolReturn)
            {
                toolReturn = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolReturnContent>(ref reader, options);
            }
            global::G.ReasoningContent? reasoning = default;
            if (discriminator?.Type == global::G.LettaMessageContentUnionDiscriminatorType.Reasoning)
            {
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReasoningContent>(ref reader, options);
            }
            global::G.RedactedReasoningContent? redactedReasoning = default;
            if (discriminator?.Type == global::G.LettaMessageContentUnionDiscriminatorType.RedactedReasoning)
            {
                redactedReasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RedactedReasoningContent>(ref reader, options);
            }
            global::G.OmittedReasoningContent? omittedReasoning = default;
            if (discriminator?.Type == global::G.LettaMessageContentUnionDiscriminatorType.OmittedReasoning)
            {
                omittedReasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OmittedReasoningContent>(ref reader, options);
            }

            var __value = new global::G.LettaMessageContentUnion(
                discriminator?.Type,
                text,

                image,

                toolCall,

                toolReturn,

                reasoning,

                redactedReasoning,

                omittedReasoning
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LettaMessageContentUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextContent), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::G.ImageContent), options);
            }
            else if (value.IsToolCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCall, typeof(global::G.ToolCallContent), options);
            }
            else if (value.IsToolReturn)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReturn, typeof(global::G.ToolReturnContent), options);
            }
            else if (value.IsReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning, typeof(global::G.ReasoningContent), options);
            }
            else if (value.IsRedactedReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedReasoning, typeof(global::G.RedactedReasoningContent), options);
            }
            else if (value.IsOmittedReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning, typeof(global::G.OmittedReasoningContent), options);
            }
        }
    }
}