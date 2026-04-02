//HintName: G.JsonConverters.CitationsVariant1Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CitationsVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CitationsVariant1Item>
    {
        /// <inheritdoc />
        public override global::G.CitationsVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestTextBlockCitationsVariant1ItemDiscriminator>(ref readerCopy, options);

            global::G.BetaRequestCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::G.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation)
            {
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestCharLocationCitation>(ref reader, options);
            }
            global::G.BetaRequestPageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::G.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation)
            {
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestPageLocationCitation>(ref reader, options);
            }
            global::G.BetaRequestContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::G.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation)
            {
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestContentBlockLocationCitation>(ref reader, options);
            }

            var __value = new global::G.CitationsVariant1Item(
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
            global::G.CitationsVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCharLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeof(global::G.BetaRequestCharLocationCitation), options);
            }
            else if (value.IsPageLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeof(global::G.BetaRequestPageLocationCitation), options);
            }
            else if (value.IsContentBlockLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeof(global::G.BetaRequestContentBlockLocationCitation), options);
            }
        }
    }
}