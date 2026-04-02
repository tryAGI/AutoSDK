//HintName: G.JsonConverters.FileSearchServerToolFiltersOneOf0ValueOneOf3Items.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>
    {
        /// <inheritdoc />
        public override global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items Read(
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

            string? fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 = default;
            double? fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 == null && fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 == null)
            {
                try
                {

                    fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items(
                fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1,

                fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1, typeof(string), options);
            }
            else if (value.IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2, typeof(double), options);
            }
        }
    }
}