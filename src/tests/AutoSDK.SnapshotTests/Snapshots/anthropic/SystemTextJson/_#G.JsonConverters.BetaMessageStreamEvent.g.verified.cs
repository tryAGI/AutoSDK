//HintName: G.JsonConverters.BetaMessageStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BetaMessageStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BetaMessageStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.BetaMessageStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaMessageStreamEventDiscriminator>(ref readerCopy, options);

            global::G.BetaMessageStartEvent? messageStart = default;
            if (discriminator?.Type == global::G.BetaMessageStreamEventDiscriminatorType.MessageStart)
            {
                messageStart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaMessageStartEvent>(ref reader, options);
            }
            global::G.BetaMessageDeltaEvent? messageDelta = default;
            if (discriminator?.Type == global::G.BetaMessageStreamEventDiscriminatorType.MessageDelta)
            {
                messageDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaMessageDeltaEvent>(ref reader, options);
            }
            global::G.BetaMessageStopEvent? messageStop = default;
            if (discriminator?.Type == global::G.BetaMessageStreamEventDiscriminatorType.MessageStop)
            {
                messageStop = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaMessageStopEvent>(ref reader, options);
            }
            global::G.BetaContentBlockStartEvent? contentBlockStart = default;
            if (discriminator?.Type == global::G.BetaMessageStreamEventDiscriminatorType.ContentBlockStart)
            {
                contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaContentBlockStartEvent>(ref reader, options);
            }
            global::G.BetaContentBlockDeltaEvent? contentBlockDelta = default;
            if (discriminator?.Type == global::G.BetaMessageStreamEventDiscriminatorType.ContentBlockDelta)
            {
                contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaContentBlockDeltaEvent>(ref reader, options);
            }
            global::G.BetaContentBlockStopEvent? contentBlockStop = default;
            if (discriminator?.Type == global::G.BetaMessageStreamEventDiscriminatorType.ContentBlockStop)
            {
                contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaContentBlockStopEvent>(ref reader, options);
            }

            var __value = new global::G.BetaMessageStreamEvent(
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
            global::G.BetaMessageStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessageStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStart, typeof(global::G.BetaMessageStartEvent), options);
            }
            else if (value.IsMessageDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDelta, typeof(global::G.BetaMessageDeltaEvent), options);
            }
            else if (value.IsMessageStop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStop, typeof(global::G.BetaMessageStopEvent), options);
            }
            else if (value.IsContentBlockStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStart, typeof(global::G.BetaContentBlockStartEvent), options);
            }
            else if (value.IsContentBlockDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockDelta, typeof(global::G.BetaContentBlockDeltaEvent), options);
            }
            else if (value.IsContentBlockStop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStop, typeof(global::G.BetaContentBlockStopEvent), options);
            }
        }
    }
}