//HintName: JsonConverters.MessageStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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

            var
            readerCopy = reader;
            global::G.MessageStartEvent? start = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStartEvent).Name}");
                start = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MessageDeltaEvent? delta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageDeltaEvent).Name}");
                delta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MessageStopEvent? stop = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStopEvent).Name}");
                stop = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentBlockStartEvent? contentBlockStart = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentBlockStartEvent).Name}");
                contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentBlockDeltaEvent? contentBlockDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentBlockDeltaEvent).Name}");
                contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentBlockStopEvent? contentBlockStop = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentBlockStopEvent).Name}");
                contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.PingEvent? ping = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PingEvent).Name}");
                ping = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::G.MessageStreamEvent(
                start,

                delta,

                stop,

                contentBlockStart,

                contentBlockDelta,

                contentBlockStop,

                ping
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::G.MessageStartEvent).Name}, {typeof(global::G.MessageDeltaEvent).Name}, {typeof(global::G.MessageStopEvent).Name}, {typeof(global::G.ContentBlockStartEvent).Name}, {typeof(global::G.ContentBlockDeltaEvent).Name}, {typeof(global::G.ContentBlockStopEvent).Name}, {typeof(global::G.PingEvent).Name}>");
            }

            if (start != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStartEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (delta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (stop != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStopEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (contentBlockStart != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentBlockStartEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (contentBlockDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentBlockDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (contentBlockStop != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentBlockStopEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (ping != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PingEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
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

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::G.MessageStartEvent).Name}, {typeof(global::G.MessageDeltaEvent).Name}, {typeof(global::G.MessageStopEvent).Name}, {typeof(global::G.ContentBlockStartEvent).Name}, {typeof(global::G.ContentBlockDeltaEvent).Name}, {typeof(global::G.ContentBlockStopEvent).Name}, {typeof(global::G.PingEvent).Name}> object.");
            }

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