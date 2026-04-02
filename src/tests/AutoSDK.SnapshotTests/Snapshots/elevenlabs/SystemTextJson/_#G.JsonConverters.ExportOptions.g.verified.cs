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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExportOptionsDiscriminator>(ref readerCopy, options);

            global::G.SegmentedJsonExportOptions? segmentedJson = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.SegmentedJson)
            {
                segmentedJson = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SegmentedJsonExportOptions>(ref reader, options);
            }
            global::G.DocxExportOptions? docx = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.Docx)
            {
                docx = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DocxExportOptions>(ref reader, options);
            }
            global::G.PdfExportOptions? pdf = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.Pdf)
            {
                pdf = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PdfExportOptions>(ref reader, options);
            }
            global::G.TxtExportOptions? txt = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.Txt)
            {
                txt = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TxtExportOptions>(ref reader, options);
            }
            global::G.HtmlExportOptions? html = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.Html)
            {
                html = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HtmlExportOptions>(ref reader, options);
            }
            global::G.SrtExportOptions? srt = default;
            if (discriminator?.Format == global::G.ExportOptionsDiscriminatorFormat.Srt)
            {
                srt = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SrtExportOptions>(ref reader, options);
            }

            var __value = new global::G.ExportOptions(
                discriminator?.Format,
                segmentedJson,

                docx,

                pdf,

                txt,

                html,

                srt
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExportOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSegmentedJson)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SegmentedJson, typeof(global::G.SegmentedJsonExportOptions), options);
            }
            else if (value.IsDocx)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Docx, typeof(global::G.DocxExportOptions), options);
            }
            else if (value.IsPdf)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pdf, typeof(global::G.PdfExportOptions), options);
            }
            else if (value.IsTxt)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Txt, typeof(global::G.TxtExportOptions), options);
            }
            else if (value.IsHtml)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Html, typeof(global::G.HtmlExportOptions), options);
            }
            else if (value.IsSrt)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Srt, typeof(global::G.SrtExportOptions), options);
            }
        }
    }
}