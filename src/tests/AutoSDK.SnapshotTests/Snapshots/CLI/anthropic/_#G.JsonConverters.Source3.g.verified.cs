//HintName: G.JsonConverters.Source3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Source3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Source3>
    {
        /// <inheritdoc />
        public override global::G.Source3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestDocumentBlockSourceDiscriminator>(ref readerCopy, options);

            global::G.Base64PDFSource? base64 = default;
            if (discriminator?.Type == global::G.RequestDocumentBlockSourceDiscriminatorType.Base64)
            {
                base64 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Base64PDFSource>(ref reader, options);
            }
            global::G.PlainTextSource? text = default;
            if (discriminator?.Type == global::G.RequestDocumentBlockSourceDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PlainTextSource>(ref reader, options);
            }
            global::G.ContentBlockSource? content = default;
            if (discriminator?.Type == global::G.RequestDocumentBlockSourceDiscriminatorType.Content)
            {
                content = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentBlockSource>(ref reader, options);
            }
            global::G.URLPDFSource? url = default;
            if (discriminator?.Type == global::G.RequestDocumentBlockSourceDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::G.URLPDFSource>(ref reader, options);
            }

            var __value = new global::G.Source3(
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
            global::G.Source3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBase64)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeof(global::G.Base64PDFSource), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.PlainTextSource), options);
            }
            else if (value.IsContent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Content, typeof(global::G.ContentBlockSource), options);
            }
            else if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::G.URLPDFSource), options);
            }
        }
    }
}