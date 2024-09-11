//HintName: JsonConverters.MessageStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AutoSDK.JsonConverters
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

            var
            readerCopy = reader;
            global::G.MessageStartEvent? start = default;
            try
            {
                start = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStartEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MessageDeltaEvent? delta = default;
            try
            {
                delta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageDeltaEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MessageStopEvent? stop = default;
            try
            {
                stop = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStopEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentBlockStartEvent? contentBlockStart = default;
            try
            {
                contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockStartEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentBlockDeltaEvent? contentBlockDelta = default;
            try
            {
                contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockDeltaEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentBlockStopEvent? contentBlockStop = default;
            try
            {
                contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockStopEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.PingEvent? ping = default;
            try
            {
                ping = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PingEvent>(ref readerCopy, options);
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

            if (start != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStartEvent>(ref reader, options);
            }
            else if (delta != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageDeltaEvent>(ref reader, options);
            }
            else if (stop != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStopEvent>(ref reader, options);
            }
            else if (contentBlockStart != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockStartEvent>(ref reader, options);
            }
            else if (contentBlockDelta != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockDeltaEvent>(ref reader, options);
            }
            else if (contentBlockStop != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockStopEvent>(ref reader, options);
            }
            else if (ping != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PingEvent>(ref reader, options);
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

            if (value.IsStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start, typeof(global::G.MessageStartEvent), options);
            }
            else if (value.IsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Delta, typeof(global::G.MessageDeltaEvent), options);
            }
            else if (value.IsStop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stop, typeof(global::G.MessageStopEvent), options);
            }
            else if (value.IsContentBlockStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStart, typeof(global::G.ContentBlockStartEvent), options);
            }
            else if (value.IsContentBlockDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockDelta, typeof(global::G.ContentBlockDeltaEvent), options);
            }
            else if (value.IsContentBlockStop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStop, typeof(global::G.ContentBlockStopEvent), options);
            }
            else if (value.IsPing)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ping, typeof(global::G.PingEvent), options);
            }
        }
    }
}