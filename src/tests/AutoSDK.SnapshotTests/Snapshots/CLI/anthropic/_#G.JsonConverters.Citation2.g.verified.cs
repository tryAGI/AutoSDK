//HintName: G.JsonConverters.Citation2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Citation2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Citation2>
    {
        /// <inheritdoc />
        public override global::G.Citation2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CitationsDeltaCitationDiscriminator>(ref readerCopy, options);

            global::G.ResponseCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::G.CitationsDeltaCitationDiscriminatorType.CharLocation)
            {
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCharLocationCitation>(ref reader, options);
            }
            global::G.ResponsePageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::G.CitationsDeltaCitationDiscriminatorType.PageLocation)
            {
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsePageLocationCitation>(ref reader, options);
            }
            global::G.ResponseContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::G.CitationsDeltaCitationDiscriminatorType.ContentBlockLocation)
            {
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseContentBlockLocationCitation>(ref reader, options);
            }

            var __value = new global::G.Citation2(
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
            global::G.Citation2 value,
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