//HintName: G.JsonConverters.CitationsVariant1Item3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CitationsVariant1Item3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CitationsVariant1Item3>
    {
        /// <inheritdoc />
        public override global::G.CitationsVariant1Item3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestTextBlockCitationsVariant1ItemDiscriminator>(ref readerCopy, options);

            global::G.RequestCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::G.RequestTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation)
            {
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestCharLocationCitation>(ref reader, options);
            }
            global::G.RequestPageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::G.RequestTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation)
            {
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestPageLocationCitation>(ref reader, options);
            }
            global::G.RequestContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::G.RequestTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation)
            {
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestContentBlockLocationCitation>(ref reader, options);
            }

            var __value = new global::G.CitationsVariant1Item3(
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
            global::G.CitationsVariant1Item3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCharLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeof(global::G.RequestCharLocationCitation), options);
            }
            else if (value.IsPageLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeof(global::G.RequestPageLocationCitation), options);
            }
            else if (value.IsContentBlockLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeof(global::G.RequestContentBlockLocationCitation), options);
            }
        }
    }
}