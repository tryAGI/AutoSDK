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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.PdfParserEngine0), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.PdfParserEngine1), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PdfParserEngine0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PdfParserEngine0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PdfParserEngine0).Name}");
                        pdfParserEngine0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PdfParserEngine1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PdfParserEngine1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PdfParserEngine1).Name}");
                        pdfParserEngine1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PdfParserEngine0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PdfParserEngine0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PdfParserEngine0).Name}");
                    pdfParserEngine0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PdfParserEngine1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PdfParserEngine1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PdfParserEngine1).Name}");
                    pdfParserEngine1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPdfParserEngine0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PdfParserEngine0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PdfParserEngine0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PdfParserEngine0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PdfParserEngine0!.Value, typeInfo);
            }
            else if (value.IsPdfParserEngine1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PdfParserEngine1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PdfParserEngine1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PdfParserEngine1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PdfParserEngine1!.Value, typeInfo);
            }
        }
    }
}