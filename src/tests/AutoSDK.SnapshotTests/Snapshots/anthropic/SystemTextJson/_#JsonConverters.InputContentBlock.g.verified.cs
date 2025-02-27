//HintName: JsonConverters.InputContentBlock.g.cs
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputContentBlockDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputContentBlockDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InputContentBlockDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RequestTextBlock? text = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestTextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestTextBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RequestImageBlock? image = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestImageBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestImageBlock)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RequestToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.ToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestToolUseBlock)}");
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RequestToolResultBlock? toolResult = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.ToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestToolResultBlock)}");
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RequestDocumentBlock? document = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.Document)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestDocumentBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestDocumentBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestDocumentBlock)}");
                document = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RequestThinkingBlock? thinking = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestThinkingBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestThinkingBlock)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RequestRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::G.InputContentBlockDiscriminatorType.RedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestRedactedThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestRedactedThinkingBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestRedactedThinkingBlock)}");
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.InputContentBlock(
                discriminator?.Type,
                text,
                image,
                toolUse,
                toolResult,
                document,
                thinking,
                redactedThinking
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestImageBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestImageBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeInfo);
            }
            else if (value.IsToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestToolResultBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestToolResultBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestDocumentBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestDocumentBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestDocumentBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestThinkingBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestThinkingBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeInfo);
            }
            else if (value.IsRedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestRedactedThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestRedactedThinkingBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestRedactedThinkingBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeInfo);
            }
        }
    }
}