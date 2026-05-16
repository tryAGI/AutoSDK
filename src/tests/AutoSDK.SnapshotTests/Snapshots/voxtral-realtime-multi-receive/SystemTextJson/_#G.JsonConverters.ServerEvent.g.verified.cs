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

            global::G.TranscriptionStreamLanguage? transcriptionLanguage = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.TranscriptionLanguage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptionStreamLanguage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptionStreamLanguage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TranscriptionStreamLanguage)}");
                transcriptionLanguage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TranscriptionStreamTextDelta? transcriptionTextDelta = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.TranscriptionTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptionStreamTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptionStreamTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TranscriptionStreamTextDelta)}");
                transcriptionTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeTranscriptionSessionCreated? sessionCreated = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.SessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeTranscriptionSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeTranscriptionSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeTranscriptionSessionCreated)}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeTranscriptionError? error = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeTranscriptionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeTranscriptionError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeTranscriptionError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ServerEvent(
                discriminator?.Type,
                transcriptionLanguage,

                transcriptionTextDelta,

                sessionCreated,

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

            if (value.IsTranscriptionLanguage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptionStreamLanguage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptionStreamLanguage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptionStreamLanguage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionLanguage!, typeInfo);
            }
            else if (value.IsTranscriptionTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptionStreamTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptionStreamTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptionStreamTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionTextDelta!, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeTranscriptionSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeTranscriptionSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeTranscriptionSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeTranscriptionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeTranscriptionError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeTranscriptionError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}