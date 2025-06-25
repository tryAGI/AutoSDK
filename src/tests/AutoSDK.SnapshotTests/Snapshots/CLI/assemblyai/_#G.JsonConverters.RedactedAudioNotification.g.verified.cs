//HintName: G.JsonConverters.RedactedAudioNotification.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RedactedAudioResponse? response = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RedactedAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RedactedAudioResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RedactedAudioResponse).Name}");
                response = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.RedactedAudioNotification(
                response
                );

            if (response != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RedactedAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RedactedAudioResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RedactedAudioResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RedactedAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RedactedAudioResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RedactedAudioResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Response, typeInfo);
            }
        }
    }
}