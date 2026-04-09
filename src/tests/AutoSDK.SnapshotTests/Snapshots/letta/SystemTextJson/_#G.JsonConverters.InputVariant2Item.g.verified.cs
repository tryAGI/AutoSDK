//HintName: G.JsonConverters.InputVariant2Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputVariant2Item>
    {
        /// <inheritdoc />
        public override global::G.InputVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationMessageRequestInputVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationMessageRequestInputVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationMessageRequestInputVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextContent? text = default;
            if (discriminator?.Type == global::G.ConversationMessageRequestInputVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextContent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageContent? image = default;
            if (discriminator?.Type == global::G.ConversationMessageRequestInputVariant2ItemDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageContent)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolCallContent? toolCall = default;
            if (discriminator?.Type == global::G.ConversationMessageRequestInputVariant2ItemDiscriminatorType.ToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolCallContent)}");
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolReturnContent? toolReturn = default;
            if (discriminator?.Type == global::G.ConversationMessageRequestInputVariant2ItemDiscriminatorType.ToolReturn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolReturnContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolReturnContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolReturnContent)}");
                toolReturn = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ReasoningContent? omittedReasoning1 = default;
            if (discriminator?.Type == global::G.ConversationMessageRequestInputVariant2ItemDiscriminatorType.OmittedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ReasoningContent)}");
                omittedReasoning1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RedactedReasoningContent? redactedReasoning = default;
            if (discriminator?.Type == global::G.ConversationMessageRequestInputVariant2ItemDiscriminatorType.RedactedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RedactedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RedactedReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RedactedReasoningContent)}");
                redactedReasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OmittedReasoningContent? omittedReasoning2 = default;
            if (discriminator?.Type == global::G.ConversationMessageRequestInputVariant2ItemDiscriminatorType.OmittedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OmittedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OmittedReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OmittedReasoningContent)}");
                omittedReasoning2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SummarizedReasoningContent? summarizedReasoning = default;
            if (discriminator?.Type == global::G.ConversationMessageRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SummarizedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SummarizedReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SummarizedReasoningContent)}");
                summarizedReasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.InputVariant2Item(
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
            global::G.InputVariant2Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCall!, typeInfo);
            }
            else if (value.IsToolReturn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolReturnContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolReturnContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolReturnContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReturn!, typeInfo);
            }
            else if (value.IsOmittedReasoning1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning1!, typeInfo);
            }
            else if (value.IsRedactedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RedactedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RedactedReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RedactedReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedReasoning!, typeInfo);
            }
            else if (value.IsOmittedReasoning2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OmittedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OmittedReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OmittedReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning2!, typeInfo);
            }
            else if (value.IsSummarizedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SummarizedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SummarizedReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SummarizedReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummarizedReasoning!, typeInfo);
            }
        }
    }
}