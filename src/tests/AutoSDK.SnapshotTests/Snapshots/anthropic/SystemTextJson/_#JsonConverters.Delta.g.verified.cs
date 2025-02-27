//HintName: JsonConverters.Delta.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DeltaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Delta>
    {
        /// <inheritdoc />
        public override global::G.Delta Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaContentBlockDeltaEventDeltaDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaContentBlockDeltaEventDeltaDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaContentBlockDeltaEventDeltaDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BetaTextContentBlockDelta? textDelta = default;
            if (discriminator?.Type == global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType.TextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaTextContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaTextContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaTextContentBlockDelta)}");
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaInputJsonContentBlockDelta? inputJsonDelta = default;
            if (discriminator?.Type == global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaInputJsonContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaInputJsonContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaInputJsonContentBlockDelta)}");
                inputJsonDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaCitationsDelta? citationsDelta = default;
            if (discriminator?.Type == global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaCitationsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaCitationsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaCitationsDelta)}");
                citationsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaThinkingContentBlockDelta? thinkingDelta = default;
            if (discriminator?.Type == global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaThinkingContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaThinkingContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaThinkingContentBlockDelta)}");
                thinkingDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaSignatureContentBlockDelta? signatureDelta = default;
            if (discriminator?.Type == global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaSignatureContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaSignatureContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaSignatureContentBlockDelta)}");
                signatureDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Delta(
                discriminator?.Type,
                textDelta,
                inputJsonDelta,
                citationsDelta,
                thinkingDelta,
                signatureDelta
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Delta value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaTextContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaTextContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaTextContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta, typeInfo);
            }
            else if (value.IsInputJsonDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaInputJsonContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaInputJsonContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaInputJsonContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputJsonDelta, typeInfo);
            }
            else if (value.IsCitationsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaCitationsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaCitationsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaCitationsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationsDelta, typeInfo);
            }
            else if (value.IsThinkingDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaThinkingContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaThinkingContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaThinkingContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingDelta, typeInfo);
            }
            else if (value.IsSignatureDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaSignatureContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaSignatureContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaSignatureContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SignatureDelta, typeInfo);
            }
        }
    }
}