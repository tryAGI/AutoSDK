//HintName: G.JsonConverters.ServerEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ServerEvent>
    {
        /// <inheritdoc />
        public override global::G.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SessionStartedPayload? sessionStarted = default;
            if (discriminator?.MessageType == global::G.ServerEventDiscriminatorMessageType.SessionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SessionStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SessionStartedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SessionStartedPayload)}");
                sessionStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PartialTranscriptPayload? partialTranscript = default;
            if (discriminator?.MessageType == global::G.ServerEventDiscriminatorMessageType.PartialTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PartialTranscriptPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PartialTranscriptPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PartialTranscriptPayload)}");
                partialTranscript = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CommittedTranscriptPayload? committedTranscript = default;
            if (discriminator?.MessageType == global::G.ServerEventDiscriminatorMessageType.CommittedTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CommittedTranscriptPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CommittedTranscriptPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CommittedTranscriptPayload)}");
                committedTranscript = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ErrorPayload? error = default;
            if (discriminator?.MessageType == global::G.ServerEventDiscriminatorMessageType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErrorPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErrorPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ErrorPayload)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ServerEvent(
                discriminator?.MessageType,
                sessionStarted,

                partialTranscript,

                committedTranscript,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SessionStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SessionStartedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SessionStartedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStarted!, typeInfo);
            }
            else if (value.IsPartialTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PartialTranscriptPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PartialTranscriptPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PartialTranscriptPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PartialTranscript!, typeInfo);
            }
            else if (value.IsCommittedTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CommittedTranscriptPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CommittedTranscriptPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CommittedTranscriptPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommittedTranscript!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErrorPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErrorPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ErrorPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}