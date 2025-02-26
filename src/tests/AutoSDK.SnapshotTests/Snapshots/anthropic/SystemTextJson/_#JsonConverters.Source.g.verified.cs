//HintName: JsonConverters.Source.g.cs
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestDocumentBlockSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestDocumentBlockSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaRequestDocumentBlockSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BetaBase64PDFSource? base64 = default;
            if (discriminator?.Type == global::G.BetaRequestDocumentBlockSourceDiscriminatorType.Base64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaBase64PDFSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaBase64PDFSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaBase64PDFSource)}");
                base64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaPlainTextSource? text = default;
            if (discriminator?.Type == global::G.BetaRequestDocumentBlockSourceDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaPlainTextSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaPlainTextSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaPlainTextSource)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaContentBlockSource? content = default;
            if (discriminator?.Type == global::G.BetaRequestDocumentBlockSourceDiscriminatorType.Content)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaContentBlockSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaContentBlockSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaContentBlockSource)}");
                content = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Source(
                discriminator?.Type,
                base64,
                text,
                content
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaBase64PDFSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaBase64PDFSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaBase64PDFSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaPlainTextSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaPlainTextSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaPlainTextSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaContentBlockSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaContentBlockSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaContentBlockSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Content, typeInfo);
            }
        }
    }
}