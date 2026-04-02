//HintName: G.JsonConverters.MessageStreamEvent.g.cs
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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventDiscriminator>(ref readerCopy, options);

            global::G.MessageStartEvent? messageStart = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.MessageStart)
            {
                messageStart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStartEvent>(ref reader, options);
            }
            global::G.MessageDeltaEvent? messageDelta = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.MessageDelta)
            {
                messageDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageDeltaEvent>(ref reader, options);
            }
            global::G.MessageStopEvent? messageStop = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.MessageStop)
            {
                messageStop = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStopEvent>(ref reader, options);
            }
            global::G.ContentBlockStartEvent? contentBlockStart = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.ContentBlockStart)
            {
                contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockStartEvent>(ref reader, options);
            }
            global::G.ContentBlockDeltaEvent? contentBlockDelta = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.ContentBlockDelta)
            {
                contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockDeltaEvent>(ref reader, options);
            }
            global::G.ContentBlockStopEvent? contentBlockStop = default;
            if (discriminator?.Type == global::G.MessageStreamEventDiscriminatorType.ContentBlockStop)
            {
                contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockStopEvent>(ref reader, options);
            }

            var __value = new global::G.MessageStreamEvent(
                discriminator?.Type,
                messageStart,

                messageDelta,

                messageStop,

                contentBlockStart,

                contentBlockDelta,

                contentBlockStop
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessageStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessageStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStart, typeof(global::G.MessageStartEvent), options);
            }
            else if (value.IsMessageDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDelta, typeof(global::G.MessageDeltaEvent), options);
            }
            else if (value.IsMessageStop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStop, typeof(global::G.MessageStopEvent), options);
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
        }
    }
}