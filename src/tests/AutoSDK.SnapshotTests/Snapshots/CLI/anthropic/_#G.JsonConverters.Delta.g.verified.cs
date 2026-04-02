//HintName: G.JsonConverters.Delta.g.cs
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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaContentBlockDeltaEventDeltaDiscriminator>(ref readerCopy, options);

            global::G.BetaTextContentBlockDelta? textDelta = default;
            if (discriminator?.Type == global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType.TextDelta)
            {
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaTextContentBlockDelta>(ref reader, options);
            }
            global::G.BetaInputJsonContentBlockDelta? inputJsonDelta = default;
            if (discriminator?.Type == global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta)
            {
                inputJsonDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaInputJsonContentBlockDelta>(ref reader, options);
            }
            global::G.BetaCitationsDelta? citationsDelta = default;
            if (discriminator?.Type == global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta)
            {
                citationsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaCitationsDelta>(ref reader, options);
            }
            global::G.BetaThinkingContentBlockDelta? thinkingDelta = default;
            if (discriminator?.Type == global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta)
            {
                thinkingDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaThinkingContentBlockDelta>(ref reader, options);
            }
            global::G.BetaSignatureContentBlockDelta? signatureDelta = default;
            if (discriminator?.Type == global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta)
            {
                signatureDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaSignatureContentBlockDelta>(ref reader, options);
            }

            var __value = new global::G.Delta(
                discriminator?.Type,
                textDelta,

                inputJsonDelta,

                citationsDelta,

                thinkingDelta,

                signatureDelta
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Delta value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta, typeof(global::G.BetaTextContentBlockDelta), options);
            }
            else if (value.IsInputJsonDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputJsonDelta, typeof(global::G.BetaInputJsonContentBlockDelta), options);
            }
            else if (value.IsCitationsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationsDelta, typeof(global::G.BetaCitationsDelta), options);
            }
            else if (value.IsThinkingDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingDelta, typeof(global::G.BetaThinkingContentBlockDelta), options);
            }
            else if (value.IsSignatureDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SignatureDelta, typeof(global::G.BetaSignatureContentBlockDelta), options);
            }
        }
    }
}