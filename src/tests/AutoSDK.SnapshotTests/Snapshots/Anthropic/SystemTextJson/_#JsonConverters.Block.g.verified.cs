//HintName: JsonConverters.Block.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AutoSDK.JsonConverters
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

            var
            readerCopy = reader;
            global::G.TextBlock? text = default;
            try
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextBlock>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ImageBlock? image = default;
            try
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageBlock>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolUseBlock? toolUse = default;
            try
            {
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolUseBlock>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolResultBlock? toolResult = default;
            try
            {
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolResultBlock>(ref readerCopy, options);
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
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextBlock>(ref reader, options);
            }
            else if (image != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageBlock>(ref reader, options);
            }
            else if (toolUse != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolUseBlock>(ref reader, options);
            }
            else if (toolResult != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolResultBlock>(ref reader, options);
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

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextBlock), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::G.ImageBlock), options);
            }
            else if (value.IsToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeof(global::G.ToolUseBlock), options);
            }
            else if (value.IsToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult, typeof(global::G.ToolResultBlock), options);
            }
        }
    }
}