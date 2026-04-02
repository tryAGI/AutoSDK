//HintName: G.JsonConverters.Formats.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FormatsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Formats>
    {
        /// <inheritdoc />
        public override global::G.Formats Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("schema")) __score2++;
            if (__jsonProps.Contains("strict")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.FormatTextConfig? formatTextConfig = default;
            global::G.FormatJsonObjectConfig? formatJsonObjectConfig = default;
            global::G.FormatJsonSchemaConfig? formatJsonSchemaConfig = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        formatTextConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FormatTextConfig>(__rawJson, options);
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
                        formatJsonObjectConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FormatJsonObjectConfig>(__rawJson, options);
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
                        formatJsonSchemaConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FormatJsonSchemaConfig>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (formatTextConfig == null && formatJsonObjectConfig == null && formatJsonSchemaConfig == null)
            {
                try
                {
                    formatTextConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FormatTextConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    formatJsonObjectConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FormatJsonObjectConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    formatJsonSchemaConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FormatJsonSchemaConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Formats(
                formatTextConfig,

                formatJsonObjectConfig,

                formatJsonSchemaConfig
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Formats value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFormatTextConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FormatTextConfig, typeof(global::G.FormatTextConfig), options);
            }
            else if (value.IsFormatJsonObjectConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FormatJsonObjectConfig, typeof(global::G.FormatJsonObjectConfig), options);
            }
            else if (value.IsFormatJsonSchemaConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FormatJsonSchemaConfig, typeof(global::G.FormatJsonSchemaConfig), options);
            }
        }
    }
}