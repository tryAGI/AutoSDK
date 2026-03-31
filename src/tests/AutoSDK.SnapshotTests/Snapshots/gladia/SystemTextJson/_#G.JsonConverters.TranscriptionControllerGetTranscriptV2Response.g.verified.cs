//HintName: G.JsonConverters.TranscriptionControllerGetTranscriptV2Response.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TranscriptionControllerGetTranscriptV2ResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TranscriptionControllerGetTranscriptV2Response>
    {
        /// <inheritdoc />
        public override global::G.TranscriptionControllerGetTranscriptV2Response Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.PreRecordedResponse? preRecorded = default;
            if (discriminator?.Kind == global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.PreRecorded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PreRecordedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PreRecordedResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PreRecordedResponse)}");
                preRecorded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamingResponse? live = default;
            if (discriminator?.Kind == global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.Live)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamingResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamingResponse)}");
                live = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.TranscriptionControllerGetTranscriptV2Response(
                discriminator?.Kind,
                preRecorded,

                live
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TranscriptionControllerGetTranscriptV2Response value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPreRecorded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PreRecordedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PreRecordedResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PreRecordedResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreRecorded!, typeInfo);
            }
            else if (value.IsLive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamingResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamingResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Live!, typeInfo);
            }
        }
    }
}