//HintName: JsonConverters.StreamedChatResponse2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class StreamedChatResponse2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StreamedChatResponse2>
    {
        /// <inheritdoc />
        public override global::G.StreamedChatResponse2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ChatMessageStartEvent? messageStartEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessageStartEvent).Name}");
                messageStartEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatContentStartEvent? contentStartEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentStartEvent).Name}");
                contentStartEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatContentDeltaEvent? contentDeltaEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentDeltaEvent).Name}");
                contentDeltaEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatContentEndEvent? contentEndEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentEndEvent).Name}");
                contentEndEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolPlanDeltaEvent? toolPlanDeltaEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolPlanDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolPlanDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolPlanDeltaEvent).Name}");
                toolPlanDeltaEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolCallStartEvent? toolCallStartEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallStartEvent).Name}");
                toolCallStartEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolCallDeltaEvent? toolCallDeltaEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallDeltaEvent).Name}");
                toolCallDeltaEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatToolCallEndEvent? toolCallEndEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallEndEvent).Name}");
                toolCallEndEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatMessageEndEvent? messageEndEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessageEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessageEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessageEndEvent).Name}");
                messageEndEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.StreamedChatResponse2(
                messageStartEvent,
                contentStartEvent,
                contentDeltaEvent,
                contentEndEvent,
                toolPlanDeltaEvent,
                toolCallStartEvent,
                toolCallDeltaEvent,
                toolCallEndEvent,
                messageEndEvent
                );

            if (messageStartEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessageStartEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (contentStartEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentStartEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (contentDeltaEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (contentEndEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentEndEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (toolPlanDeltaEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolPlanDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolPlanDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolPlanDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (toolCallStartEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallStartEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (toolCallDeltaEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (toolCallEndEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallEndEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (messageEndEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessageEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessageEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessageEndEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.StreamedChatResponse2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageStartEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessageStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessageStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStartEvent, typeInfo);
            }
            else if (value.IsContentStartEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentStartEvent, typeInfo);
            }
            else if (value.IsContentDeltaEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentDeltaEvent, typeInfo);
            }
            else if (value.IsContentEndEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentEndEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentEndEvent, typeInfo);
            }
            else if (value.IsToolPlanDeltaEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolPlanDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolPlanDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolPlanDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolPlanDeltaEvent, typeInfo);
            }
            else if (value.IsToolCallStartEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallStartEvent, typeInfo);
            }
            else if (value.IsToolCallDeltaEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallDeltaEvent, typeInfo);
            }
            else if (value.IsToolCallEndEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallEndEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallEndEvent, typeInfo);
            }
            else if (value.IsMessageEndEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessageEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessageEndEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessageEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageEndEvent, typeInfo);
            }
        }
    }
}