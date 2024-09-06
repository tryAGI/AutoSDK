//HintName: JsonConverters.RedactedAudioNotification.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class RedactedAudioNotificationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RedactedAudioNotification>
    {
        /// <inheritdoc />
        public override global::G.RedactedAudioNotification Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.RedactedAudioResponse? response = default;
            try
            {
                response = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RedactedAudioResponse>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.RedactedAudioNotification(
                response
                );

            if (response != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RedactedAudioResponse>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RedactedAudioNotification value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsResponse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Response, typeof(global::G.RedactedAudioResponse), options);
            }
        }
    }
}