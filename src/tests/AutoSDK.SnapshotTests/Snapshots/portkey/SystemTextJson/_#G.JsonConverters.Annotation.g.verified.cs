//HintName: G.JsonConverters.Annotation.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AnnotationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Annotation>
    {
        /// <inheritdoc />
        public override global::G.Annotation Read(
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
            if (__jsonProps.Contains("file_id")) __score0++;
            if (__jsonProps.Contains("index")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("end_index")) __score1++;
            if (__jsonProps.Contains("start_index")) __score1++;
            if (__jsonProps.Contains("title")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("file_id")) __score2++;
            if (__jsonProps.Contains("index")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.FileCitation? fileCitation = default;
            global::G.UrlCitation? urlCitation = default;
            global::G.FilePath? filePath = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        fileCitation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileCitation>(__rawJson, options);
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
                        urlCitation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UrlCitation>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        filePath = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FilePath>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (fileCitation == null && urlCitation == null && filePath == null)
            {
                try
                {
                    fileCitation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileCitation>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    urlCitation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UrlCitation>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    filePath = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FilePath>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Annotation(
                fileCitation,

                urlCitation,

                filePath
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Annotation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFileCitation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileCitation, typeof(global::G.FileCitation), options);
            }
            else if (value.IsUrlCitation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UrlCitation, typeof(global::G.UrlCitation), options);
            }
            else if (value.IsFilePath)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilePath, typeof(global::G.FilePath), options);
            }
        }
    }
}