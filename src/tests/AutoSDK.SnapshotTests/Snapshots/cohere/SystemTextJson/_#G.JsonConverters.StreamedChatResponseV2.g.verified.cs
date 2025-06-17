//HintName: G.JsonConverters.StreamedChatResponseV2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class StreamedChatResponseV2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StreamedChatResponseV2>
    {
        /// <inheritdoc />
        public override global::G.StreamedChatResponseV2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamedChatResponseV2Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamedChatResponseV2Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamedChatResponseV2Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ChatMessageStartEvent? messageStart = default;
            if (discriminator?.Type == global::G.StreamedChatResponseV2DiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatMessageStartEvent)}");
                messageStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatContentStartEvent? contentStart = default;
            if (discriminator?.Type == global::G.StreamedChatResponseV2DiscriminatorType.ContentStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatContentStartEvent)}");
                contentStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatContentDeltaEvent? contentDelta = default;
            if (discriminator?.Type == global::G.StreamedChatResponseV2DiscriminatorType.ContentDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatContentDeltaEvent)}");
                contentDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatContentEndEvent? contentEnd = default;
            if (discriminator?.Type == global::G.StreamedChatResponseV2DiscriminatorType.ContentEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatContentEndEvent)}");
                contentEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatToolPlanDeltaEvent? toolPlanDelta = default;
            if (discriminator?.Type == global::G.StreamedChatResponseV2DiscriminatorType.ToolPlanDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolPlanDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolPlanDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatToolPlanDeltaEvent)}");
                toolPlanDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatToolCallStartEvent? toolCallStart = default;
            if (discriminator?.Type == global::G.StreamedChatResponseV2DiscriminatorType.ToolCallStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatToolCallStartEvent)}");
                toolCallStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatToolCallDeltaEvent? toolCallDelta = default;
            if (discriminator?.Type == global::G.StreamedChatResponseV2DiscriminatorType.ToolCallDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatToolCallDeltaEvent)}");
                toolCallDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatToolCallEndEvent? toolCallEnd = default;
            if (discriminator?.Type == global::G.StreamedChatResponseV2DiscriminatorType.ToolCallEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatToolCallEndEvent)}");
                toolCallEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatMessageEndEvent? messageEnd = default;
            if (discriminator?.Type == global::G.StreamedChatResponseV2DiscriminatorType.MessageEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessageEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessageEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatMessageEndEvent)}");
                messageEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatDebugEvent? debug = default;
            if (discriminator?.Type == global::G.StreamedChatResponseV2DiscriminatorType.Debug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatDebugEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatDebugEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatDebugEvent)}");
                debug = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.StreamedChatResponseV2(
                discriminator?.Type,
                messageStart,
                contentStart,
                contentDelta,
                contentEnd,
                toolPlanDelta,
                toolCallStart,
                toolCallDelta,
                toolCallEnd,
                messageEnd,
                debug
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.StreamedChatResponseV2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessageStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStart, typeInfo);
            }
            else if (value.IsContentStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentStart, typeInfo);
            }
            else if (value.IsContentDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentDelta, typeInfo);
            }
            else if (value.IsContentEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentEnd, typeInfo);
            }
            else if (value.IsToolPlanDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolPlanDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolPlanDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolPlanDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolPlanDelta, typeInfo);
            }
            else if (value.IsToolCallStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallStart, typeInfo);
            }
            else if (value.IsToolCallDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallDelta, typeInfo);
            }
            else if (value.IsToolCallEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolCallEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolCallEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolCallEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallEnd, typeInfo);
            }
            else if (value.IsMessageEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessageEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessageEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessageEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageEnd, typeInfo);
            }
            else if (value.IsDebug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatDebugEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatDebugEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatDebugEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Debug, typeInfo);
            }
        }
    }
}