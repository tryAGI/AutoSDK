//HintName: G.JsonConverters.CreateTranscriptionResponseStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateTranscriptionResponseStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTranscriptionResponseStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.CreateTranscriptionResponseStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTranscriptionResponseStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTranscriptionResponseStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTranscriptionResponseStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TranscriptTextDeltaEvent? transcriptTextDelta = default;
            if (discriminator?.Type == "transcript.text.delta")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TranscriptTextDeltaEvent)}");
                transcriptTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TranscriptTextDoneEvent? transcriptTextDone = default;
            if (discriminator?.Type == "transcript.text.done")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TranscriptTextDoneEvent)}");
                transcriptTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateTranscriptionResponseStreamEvent(
                discriminator?.Type,
                transcriptTextDelta,

                transcriptTextDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTranscriptionResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranscriptTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptTextDelta!, typeInfo);
            }
            else if (value.IsTranscriptTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptTextDone!, typeInfo);
            }
        }
    }
}