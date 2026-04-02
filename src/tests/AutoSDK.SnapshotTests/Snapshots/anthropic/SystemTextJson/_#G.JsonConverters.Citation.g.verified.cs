//HintName: G.JsonConverters.Citation.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CitationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Citation>
    {
        /// <inheritdoc />
        public override global::G.Citation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaCitationsDeltaCitationDiscriminator>(ref readerCopy, options);

            global::G.BetaResponseCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::G.BetaCitationsDeltaCitationDiscriminatorType.CharLocation)
            {
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponseCharLocationCitation>(ref reader, options);
            }
            global::G.BetaResponsePageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::G.BetaCitationsDeltaCitationDiscriminatorType.PageLocation)
            {
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponsePageLocationCitation>(ref reader, options);
            }
            global::G.BetaResponseContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::G.BetaCitationsDeltaCitationDiscriminatorType.ContentBlockLocation)
            {
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponseContentBlockLocationCitation>(ref reader, options);
            }

            var __value = new global::G.Citation(
                discriminator?.Type,
                charLocation,

                pageLocation,

                contentBlockLocation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Citation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCharLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeof(global::G.BetaResponseCharLocationCitation), options);
            }
            else if (value.IsPageLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeof(global::G.BetaResponsePageLocationCitation), options);
            }
            else if (value.IsContentBlockLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeof(global::G.BetaResponseContentBlockLocationCitation), options);
            }
        }
    }
}