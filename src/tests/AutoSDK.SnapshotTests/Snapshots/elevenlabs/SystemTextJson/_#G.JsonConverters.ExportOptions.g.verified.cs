//HintName: G.JsonConverters.ExportOptions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ExportOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ExportOptions>
    {
        /// <inheritdoc />
        public override global::G.ExportOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExportOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExportOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ExportOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SegmentedJsonExportOptions? segmentedJson = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.SegmentedJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SegmentedJsonExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SegmentedJsonExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SegmentedJsonExportOptions)}");
                segmentedJson = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DocxExportOptions? docx = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.Docx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocxExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocxExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DocxExportOptions)}");
                docx = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PdfExportOptions? pdf = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.Pdf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PdfExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PdfExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PdfExportOptions)}");
                pdf = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TxtExportOptions? txt = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.Txt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TxtExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TxtExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TxtExportOptions)}");
                txt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HtmlExportOptions? html = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.Html)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HtmlExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HtmlExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HtmlExportOptions)}");
                html = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SrtExportOptions? srt = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.Srt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SrtExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SrtExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SrtExportOptions)}");
                srt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ExportOptions(
                discriminator?.Format,
                segmentedJson,
                docx,
                pdf,
                txt,
                html,
                srt
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExportOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSegmentedJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SegmentedJsonExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SegmentedJsonExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SegmentedJsonExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SegmentedJson, typeInfo);
            }
            else if (value.IsDocx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocxExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocxExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DocxExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Docx, typeInfo);
            }
            else if (value.IsPdf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PdfExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PdfExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PdfExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pdf, typeInfo);
            }
            else if (value.IsTxt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TxtExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TxtExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TxtExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Txt, typeInfo);
            }
            else if (value.IsHtml)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HtmlExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HtmlExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HtmlExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Html, typeInfo);
            }
            else if (value.IsSrt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SrtExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SrtExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SrtExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Srt, typeInfo);
            }
        }
    }
}