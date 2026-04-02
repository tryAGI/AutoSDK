//HintName: G.JsonConverters.Delta2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Delta2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Delta2>
    {
        /// <inheritdoc />
        public override global::G.Delta2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockDeltaEventDeltaDiscriminator>(ref readerCopy, options);

            global::G.TextContentBlockDelta? textDelta = default;
            if (discriminator?.Type == global::G.ContentBlockDeltaEventDeltaDiscriminatorType.TextDelta)
            {
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextContentBlockDelta>(ref reader, options);
            }
            global::G.InputJsonContentBlockDelta? inputJsonDelta = default;
            if (discriminator?.Type == global::G.ContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta)
            {
                inputJsonDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputJsonContentBlockDelta>(ref reader, options);
            }
            global::G.CitationsDelta? citationsDelta = default;
            if (discriminator?.Type == global::G.ContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta)
            {
                citationsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CitationsDelta>(ref reader, options);
            }
            global::G.ThinkingContentBlockDelta? thinkingDelta = default;
            if (discriminator?.Type == global::G.ContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta)
            {
                thinkingDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ThinkingContentBlockDelta>(ref reader, options);
            }
            global::G.SignatureContentBlockDelta? signatureDelta = default;
            if (discriminator?.Type == global::G.ContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta)
            {
                signatureDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SignatureContentBlockDelta>(ref reader, options);
            }

            var __value = new global::G.Delta2(
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
            global::G.Delta2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta, typeof(global::G.TextContentBlockDelta), options);
            }
            else if (value.IsInputJsonDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputJsonDelta, typeof(global::G.InputJsonContentBlockDelta), options);
            }
            else if (value.IsCitationsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationsDelta, typeof(global::G.CitationsDelta), options);
            }
            else if (value.IsThinkingDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingDelta, typeof(global::G.ThinkingContentBlockDelta), options);
            }
            else if (value.IsSignatureDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SignatureDelta, typeof(global::G.SignatureContentBlockDelta), options);
            }
        }
    }
}