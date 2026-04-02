//HintName: G.JsonConverters.CitationsVariant1Item2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CitationsVariant1Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CitationsVariant1Item2>
    {
        /// <inheritdoc />
        public override global::G.CitationsVariant1Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponseTextBlockCitationsVariant1ItemDiscriminator>(ref readerCopy, options);

            global::G.BetaResponseCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::G.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation)
            {
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponseCharLocationCitation>(ref reader, options);
            }
            global::G.BetaResponsePageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::G.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation)
            {
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponsePageLocationCitation>(ref reader, options);
            }
            global::G.BetaResponseContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::G.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation)
            {
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaResponseContentBlockLocationCitation>(ref reader, options);
            }

            var __value = new global::G.CitationsVariant1Item2(
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
            global::G.CitationsVariant1Item2 value,
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