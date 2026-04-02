//HintName: G.JsonConverters.ExportDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ExportDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ExportDto>
    {
        /// <inheritdoc />
        public override global::G.ExportDto Read(
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
            if (__jsonProps.Contains("agent_id")) __score0++;
            if (__jsonProps.Contains("from")) __score0++;
            if (__jsonProps.Contains("persistent_chats")) __score0++;
            if (__jsonProps.Contains("to")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("token")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ExportDtoVariant1? exportDtoVariant1 = default;
            global::G.ExportDtoVariant2? exportDtoVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        exportDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExportDtoVariant1>(__rawJson, options);
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
                        exportDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExportDtoVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (exportDtoVariant1 == null && exportDtoVariant2 == null)
            {
                try
                {
                    exportDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExportDtoVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    exportDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExportDtoVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ExportDto(
                exportDtoVariant1,

                exportDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExportDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsExportDtoVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExportDtoVariant1, typeof(global::G.ExportDtoVariant1), options);
            }
            else if (value.IsExportDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExportDtoVariant2, typeof(global::G.ExportDtoVariant2), options);
            }
        }
    }
}