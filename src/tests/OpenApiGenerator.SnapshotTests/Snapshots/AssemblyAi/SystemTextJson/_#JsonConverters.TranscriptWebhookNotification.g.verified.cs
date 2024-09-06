//HintName: JsonConverters.TranscriptWebhookNotification.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class TranscriptWebhookNotificationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TranscriptWebhookNotification>
    {
        /// <inheritdoc />
        public override global::G.TranscriptWebhookNotification Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.TranscriptReadyNotification? ready = default;
            try
            {
                ready = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranscriptReadyNotification>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RedactedAudioNotification? redactedAudio = default;
            try
            {
                redactedAudio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RedactedAudioNotification>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.TranscriptWebhookNotification(
                ready,
                redactedAudio
                );

            if (ready != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranscriptReadyNotification>(ref reader, options);
            }
            else if (redactedAudio != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RedactedAudioNotification>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TranscriptWebhookNotification value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsReady)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ready, typeof(global::G.TranscriptReadyNotification), options);
            }
            else if (value.IsRedactedAudio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedAudio, typeof(global::G.RedactedAudioNotification), options);
            }
        }
    }
}