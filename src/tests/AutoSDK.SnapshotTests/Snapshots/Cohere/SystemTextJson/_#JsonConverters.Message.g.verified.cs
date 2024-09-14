//HintName: JsonConverters.Message.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Message>
    {
        /// <inheritdoc />
        public override global::G.Message Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ChatMessage? chat = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessage).Name}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolMessage? tool = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolMessage).Name}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Message(
                chat,
                tool
                );

            if (chat != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (tool != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Message value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}