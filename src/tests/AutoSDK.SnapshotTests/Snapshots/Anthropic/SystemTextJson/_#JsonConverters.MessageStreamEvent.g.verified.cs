//HintName: JsonConverters.MessageStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessageStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessageStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.MessageStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.MessageStartEvent? start = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageStartEvent)}");
                start = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageDeltaEvent? delta = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageDeltaEvent)}");
                delta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MessageStopEvent? stop = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageStopEvent)}");
                stop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ContentBlockStartEvent? contentBlockStart = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContentBlockStartEvent)}");
                contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ContentBlockDeltaEvent? contentBlockDelta = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContentBlockDeltaEvent)}");
                contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ContentBlockStopEvent? contentBlockStop = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContentBlockStopEvent)}");
                contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PingEvent? ping = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PingEvent)}");
                ping = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.MessageStreamEvent(
                discriminator?.Type,
                start,
                delta,
                stop,
                contentBlockStart,
                contentBlockDelta,
                contentBlockStop,
                ping
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessageStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start, typeInfo);
            }
            else if (value.IsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Delta, typeInfo);
            }
            else if (value.IsStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStopEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStopEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stop, typeInfo);
            }
            else if (value.IsContentBlockStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentBlockStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStart, typeInfo);
            }
            else if (value.IsContentBlockDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentBlockDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockDelta, typeInfo);
            }
            else if (value.IsContentBlockStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockStopEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentBlockStopEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStop, typeInfo);
            }
            else if (value.IsPing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ping, typeInfo);
            }
        }
    }
}