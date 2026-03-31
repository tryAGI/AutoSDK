//HintName: G.JsonConverters.ContentVariant2Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentVariant2Item>
    {
        /// <inheritdoc />
        public override global::G.ContentVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptMessageContentVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptMessageContentVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptMessageContentVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextContentPart? text = default;
            if (discriminator?.Type == global::G.PromptMessageContentVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContentPart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextContentPart)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolCallContentPart? toolCall = default;
            if (discriminator?.Type == global::G.PromptMessageContentVariant2ItemDiscriminatorType.ToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallContentPart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolCallContentPart)}");
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolResultContentPart? toolResult = default;
            if (discriminator?.Type == global::G.PromptMessageContentVariant2ItemDiscriminatorType.ToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolResultContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolResultContentPart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolResultContentPart)}");
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ContentVariant2Item(
                discriminator?.Type,
                text,

                toolCall,

                toolResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentVariant2Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContentPart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextContentPart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallContentPart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallContentPart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCall!, typeInfo);
            }
            else if (value.IsToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolResultContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolResultContentPart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolResultContentPart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult!, typeInfo);
            }
        }
    }
}