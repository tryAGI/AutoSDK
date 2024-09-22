//HintName: JsonConverters.ChatMessageV2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatMessageV2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatMessageV2>
    {
        /// <inheritdoc />
        public override global::G.ChatMessageV2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.UserMessage? user = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UserMessage).Name}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AssistantMessage? assistant = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantMessage).Name}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.SystemMessage? system = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SystemMessage).Name}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolMessageV2? tool = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessageV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolMessageV2).Name}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ChatMessageV2(
                user,
                assistant,
                system,
                tool
                );

            if (user != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UserMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (assistant != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (system != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SystemMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (tool != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessageV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolMessageV2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatMessageV2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessageV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolMessageV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}