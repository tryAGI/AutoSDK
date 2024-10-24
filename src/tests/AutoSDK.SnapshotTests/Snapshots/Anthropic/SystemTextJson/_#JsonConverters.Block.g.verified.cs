//HintName: JsonConverters.Block.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Block>
    {
        /// <inheritdoc />
        public override global::G.Block Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BlockDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BlockDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BlockDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextBlock? text = default;
            if (discriminator?.Type == global::G.BlockDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageBlock? image = default;
            if (discriminator?.Type == global::G.BlockDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageBlock)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::G.BlockDiscriminatorType.ToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolUseBlock)}");
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolResultBlock? toolResult = default;
            if (discriminator?.Type == global::G.BlockDiscriminatorType.ToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolResultBlock)}");
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Block(
                discriminator?.Type,
                text,
                image,
                toolUse,
                toolResult
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Block value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeInfo);
            }
            else if (value.IsToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolResultBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolResultBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult, typeInfo);
            }
        }
    }
}