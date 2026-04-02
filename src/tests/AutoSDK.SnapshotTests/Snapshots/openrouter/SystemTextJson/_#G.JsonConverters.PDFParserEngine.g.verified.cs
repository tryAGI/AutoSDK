//HintName: G.JsonConverters.PDFParserEngine.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PDFParserEngineJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PDFParserEngine>
    {
        /// <inheritdoc />
        public override global::G.PDFParserEngine Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.PdfParserEngine0? pdfParserEngine0 = default;
            global::G.PdfParserEngine1? pdfParserEngine1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        pdfParserEngine0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PdfParserEngine0>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        pdfParserEngine1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PdfParserEngine1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pdfParserEngine0 == null && pdfParserEngine1 == null)
            {
                try
                {

                    pdfParserEngine0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PdfParserEngine0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    pdfParserEngine1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PdfParserEngine1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.PDFParserEngine(
                pdfParserEngine0,

                pdfParserEngine1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PDFParserEngine value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPdfParserEngine0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PdfParserEngine0, typeof(global::G.PdfParserEngine0), options);
            }
            else if (value.IsPdfParserEngine1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PdfParserEngine1, typeof(global::G.PdfParserEngine1), options);
            }
        }
    }
}