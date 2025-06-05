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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockStartEventContentBlockDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockStartEventContentBlockDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContentBlockStartEventContentBlockDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResponseTextBlock? text = default;
            if (discriminator?.Type == global::G.ContentBlockStartEventContentBlockDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseTextBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::G.ContentBlockStartEventContentBlockDiscriminatorType.ToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseToolUseBlock)}");
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseThinkingBlock? thinking = default;
            if (discriminator?.Type == global::G.ContentBlockStartEventContentBlockDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseThinkingBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseThinkingBlock)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::G.ContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRedactedThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRedactedThinkingBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseRedactedThinkingBlock)}");
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ContentBlock2(
                discriminator?.Type,
                text,
                toolUse,
                thinking,
                redactedThinking
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentBlock2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseThinkingBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseThinkingBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeInfo);
            }
            else if (value.IsRedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRedactedThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRedactedThinkingBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRedactedThinkingBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeInfo);
            }
        }
    }
}