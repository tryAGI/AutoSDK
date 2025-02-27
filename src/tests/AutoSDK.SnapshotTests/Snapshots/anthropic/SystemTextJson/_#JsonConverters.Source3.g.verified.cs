//HintName: JsonConverters.Source3.g.cs
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestDocumentBlockSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestDocumentBlockSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestDocumentBlockSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.Base64PDFSource? base64 = default;
            if (discriminator?.Type == global::G.RequestDocumentBlockSourceDiscriminatorType.Base64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Base64PDFSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Base64PDFSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.Base64PDFSource)}");
                base64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PlainTextSource? text = default;
            if (discriminator?.Type == global::G.RequestDocumentBlockSourceDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PlainTextSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PlainTextSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PlainTextSource)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ContentBlockSource? content = default;
            if (discriminator?.Type == global::G.RequestDocumentBlockSourceDiscriminatorType.Content)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContentBlockSource)}");
                content = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.URLPDFSource? url = default;
            if (discriminator?.Type == global::G.RequestDocumentBlockSourceDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.URLPDFSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.URLPDFSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.URLPDFSource)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Source3(
                discriminator?.Type,
                base64,
                text,
                content,
                url
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Base64PDFSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Base64PDFSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Base64PDFSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PlainTextSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PlainTextSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PlainTextSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentBlockSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Content, typeInfo);
            }
            else if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.URLPDFSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.URLPDFSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.URLPDFSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeInfo);
            }
        }
    }
}