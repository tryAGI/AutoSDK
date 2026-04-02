//HintName: G.JsonConverters.InputVariant2Item3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputVariant2Item3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputVariant2Item3>
    {
        /// <inheritdoc />
        public override global::G.InputVariant2Item3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaBatchRequestInputVariant2ItemDiscriminator>(ref readerCopy, options);

            global::G.TextContent? text = default;
            if (discriminator?.Type == global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextContent>(ref reader, options);
            }
            global::G.ImageContent? image = default;
            if (discriminator?.Type == global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageContent>(ref reader, options);
            }
            global::G.ToolCallContent? toolCall = default;
            if (discriminator?.Type == global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType.ToolCall)
            {
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolCallContent>(ref reader, options);
            }
            global::G.ToolReturnContent? toolReturn = default;
            if (discriminator?.Type == global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType.ToolReturn)
            {
                toolReturn = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolReturnContent>(ref reader, options);
            }
            global::G.ReasoningContent? omittedReasoning1 = default;
            if (discriminator?.Type == global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType.OmittedReasoning)
            {
                omittedReasoning1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReasoningContent>(ref reader, options);
            }
            global::G.RedactedReasoningContent? redactedReasoning = default;
            if (discriminator?.Type == global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType.RedactedReasoning)
            {
                redactedReasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RedactedReasoningContent>(ref reader, options);
            }
            global::G.OmittedReasoningContent? omittedReasoning2 = default;
            if (discriminator?.Type == global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType.OmittedReasoning)
            {
                omittedReasoning2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OmittedReasoningContent>(ref reader, options);
            }
            global::G.SummarizedReasoningContent? summarizedReasoning = default;
            if (discriminator?.Type == global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning)
            {
                summarizedReasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SummarizedReasoningContent>(ref reader, options);
            }

            var __value = new global::G.InputVariant2Item3(
                discriminator?.Type,
                text,

                image,

                toolCall,

                toolReturn,

                omittedReasoning1,

                redactedReasoning,

                omittedReasoning2,

                summarizedReasoning
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputVariant2Item3 value,
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
            else if (value.IsOmittedReasoning1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning1, typeof(global::G.ReasoningContent), options);
            }
            else if (value.IsRedactedReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedReasoning, typeof(global::G.RedactedReasoningContent), options);
            }
            else if (value.IsOmittedReasoning2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning2, typeof(global::G.OmittedReasoningContent), options);
            }
            else if (value.IsSummarizedReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummarizedReasoning, typeof(global::G.SummarizedReasoningContent), options);
            }
        }
    }
}