//HintName: G.JsonConverters.Source.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Source>
    {
        /// <inheritdoc />
        public override global::G.Source Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestDocumentBlockSourceDiscriminator>(ref readerCopy, options);

            global::G.BetaBase64PDFSource? base64 = default;
            if (discriminator?.Type == global::G.BetaRequestDocumentBlockSourceDiscriminatorType.Base64)
            {
                base64 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaBase64PDFSource>(ref reader, options);
            }
            global::G.BetaPlainTextSource? text = default;
            if (discriminator?.Type == global::G.BetaRequestDocumentBlockSourceDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaPlainTextSource>(ref reader, options);
            }
            global::G.BetaContentBlockSource? content = default;
            if (discriminator?.Type == global::G.BetaRequestDocumentBlockSourceDiscriminatorType.Content)
            {
                content = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaContentBlockSource>(ref reader, options);
            }
            global::G.BetaURLPDFSource? url = default;
            if (discriminator?.Type == global::G.BetaRequestDocumentBlockSourceDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaURLPDFSource>(ref reader, options);
            }

            var __value = new global::G.Source(
                discriminator?.Type,
                base64,

                text,

                content,

                url
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBase64)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeof(global::G.BetaBase64PDFSource), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.BetaPlainTextSource), options);
            }
            else if (value.IsContent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Content, typeof(global::G.BetaContentBlockSource), options);
            }
            else if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::G.BetaURLPDFSource), options);
            }
        }
    }
}