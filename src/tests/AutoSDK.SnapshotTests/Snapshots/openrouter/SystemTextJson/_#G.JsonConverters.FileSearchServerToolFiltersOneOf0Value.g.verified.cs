//HintName: G.JsonConverters.FileSearchServerToolFiltersOneOf0Value.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FileSearchServerToolFiltersOneOf0ValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FileSearchServerToolFiltersOneOf0Value>
    {
        /// <inheritdoc />
        public override global::G.FileSearchServerToolFiltersOneOf0Value Read(
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
            var __score2 = 0;
            var __score3 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            string? fileSearchServerToolFiltersOneOf0ValueVariant1 = default;
            double? fileSearchServerToolFiltersOneOf0ValueVariant2 = default;
            bool? fileSearchServerToolFiltersOneOf0ValueVariant3 = default;
            global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>? fileSearchServerToolFiltersOneOf0Value3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        fileSearchServerToolFiltersOneOf0ValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        fileSearchServerToolFiltersOneOf0ValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
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

                        fileSearchServerToolFiltersOneOf0ValueVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        fileSearchServerToolFiltersOneOf0Value3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (fileSearchServerToolFiltersOneOf0ValueVariant1 == null && fileSearchServerToolFiltersOneOf0ValueVariant2 == null && fileSearchServerToolFiltersOneOf0ValueVariant3 == null && fileSearchServerToolFiltersOneOf0Value3 == null)
            {
                try
                {

                    fileSearchServerToolFiltersOneOf0ValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    fileSearchServerToolFiltersOneOf0ValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    fileSearchServerToolFiltersOneOf0ValueVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    fileSearchServerToolFiltersOneOf0Value3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FileSearchServerToolFiltersOneOf0Value(
                fileSearchServerToolFiltersOneOf0ValueVariant1,

                fileSearchServerToolFiltersOneOf0ValueVariant2,

                fileSearchServerToolFiltersOneOf0ValueVariant3,

                fileSearchServerToolFiltersOneOf0Value3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FileSearchServerToolFiltersOneOf0Value value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFileSearchServerToolFiltersOneOf0ValueVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchServerToolFiltersOneOf0ValueVariant1, typeof(string), options);
            }
            else if (value.IsFileSearchServerToolFiltersOneOf0ValueVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchServerToolFiltersOneOf0ValueVariant2, typeof(double), options);
            }
            else if (value.IsFileSearchServerToolFiltersOneOf0ValueVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchServerToolFiltersOneOf0ValueVariant3, typeof(bool), options);
            }
            else if (value.IsFileSearchServerToolFiltersOneOf0Value3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchServerToolFiltersOneOf0Value3, typeof(global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>), options);
            }
        }
    }
}