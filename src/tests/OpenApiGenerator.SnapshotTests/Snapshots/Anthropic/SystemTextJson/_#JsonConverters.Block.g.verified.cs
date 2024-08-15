//HintName: JsonConverters.Block.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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

            var
            readerCopy = reader;
            global::G.TextBlock? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextBlock).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ImageBlock? image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageBlock).Name}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolUseBlock? toolUse = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolUseBlock).Name}");
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolResultBlock? toolResult = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolResultBlock).Name}");
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Block(
                text,
                image,
                toolUse,
                toolResult
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (toolUse != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolUseBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (toolResult != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolResultBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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