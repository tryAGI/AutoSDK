//HintName: G.JsonConverters.SpeakV1ServerEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SpeakV1ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SpeakV1ServerEvent>
    {
        /// <inheritdoc />
        public override global::G.SpeakV1ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SpeakV1ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SpeakV1ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SpeakV1ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.AudioResponsePayload? audioResponse = default;
            if (discriminator?.MessageType == global::G.SpeakV1ServerEventDiscriminatorMessageType.AudioResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AudioResponsePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AudioResponsePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AudioResponsePayload)}");
                audioResponse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SpeakMetadataPayload? speakMetadata = default;
            if (discriminator?.MessageType == global::G.SpeakV1ServerEventDiscriminatorMessageType.SpeakMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SpeakMetadataPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SpeakMetadataPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SpeakMetadataPayload)}");
                speakMetadata = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.SpeakV1ServerEvent(
                discriminator?.MessageType,
                audioResponse,

                speakMetadata
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SpeakV1ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAudioResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AudioResponsePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AudioResponsePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AudioResponsePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioResponse, typeInfo);
            }
            else if (value.IsSpeakMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SpeakMetadataPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SpeakMetadataPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SpeakMetadataPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakMetadata, typeInfo);
            }
        }
    }
}