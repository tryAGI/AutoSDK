//HintName: G.JsonConverters.ListenV1ServerEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ListenV1ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListenV1ServerEvent>
    {
        /// <inheritdoc />
        public override global::G.ListenV1ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListenV1ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListenV1ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListenV1ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TranscriptResultPayload? transcriptResult = default;
            if (discriminator?.MessageType == global::G.ListenV1ServerEventDiscriminatorMessageType.TranscriptResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptResultPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptResultPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TranscriptResultPayload)}");
                transcriptResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ListenMetadataPayload? listenMetadata = default;
            if (discriminator?.MessageType == global::G.ListenV1ServerEventDiscriminatorMessageType.ListenMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListenMetadataPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListenMetadataPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListenMetadataPayload)}");
                listenMetadata = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ListenV1ServerEvent(
                discriminator?.MessageType,
                transcriptResult,

                listenMetadata
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListenV1ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranscriptResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptResultPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptResultPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptResultPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptResult!, typeInfo);
            }
            else if (value.IsListenMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListenMetadataPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListenMetadataPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListenMetadataPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListenMetadata!, typeInfo);
            }
        }
    }
}