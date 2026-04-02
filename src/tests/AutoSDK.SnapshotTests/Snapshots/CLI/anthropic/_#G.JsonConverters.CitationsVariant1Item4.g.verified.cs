//HintName: G.JsonConverters.CitationsVariant1Item4.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CitationsVariant1Item4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CitationsVariant1Item4>
    {
        /// <inheritdoc />
        public override global::G.CitationsVariant1Item4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseTextBlockCitationsVariant1ItemDiscriminator>(ref readerCopy, options);

            global::G.ResponseCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::G.ResponseTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation)
            {
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCharLocationCitation>(ref reader, options);
            }
            global::G.ResponsePageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::G.ResponseTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation)
            {
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsePageLocationCitation>(ref reader, options);
            }
            global::G.ResponseContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::G.ResponseTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation)
            {
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseContentBlockLocationCitation>(ref reader, options);
            }

            var __value = new global::G.CitationsVariant1Item4(
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
            global::G.CitationsVariant1Item4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCharLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeof(global::G.ResponseCharLocationCitation), options);
            }
            else if (value.IsPageLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeof(global::G.ResponsePageLocationCitation), options);
            }
            else if (value.IsContentBlockLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeof(global::G.ResponseContentBlockLocationCitation), options);
            }
        }
    }
}