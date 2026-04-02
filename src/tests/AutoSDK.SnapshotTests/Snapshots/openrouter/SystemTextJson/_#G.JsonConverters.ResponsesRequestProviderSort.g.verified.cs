//HintName: G.JsonConverters.ResponsesRequestProviderSort.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesRequestProviderSortJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponsesRequestProviderSort>
    {
        /// <inheritdoc />
        public override global::G.ResponsesRequestProviderSort Read(
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
            if (__jsonProps.Contains("by")) __score1++;
            if (__jsonProps.Contains("partition")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.ProviderSort? providerSort = default;
            global::G.ProviderSortConfig? providerSortConfig = default;
            object? responsesRequestProviderSortVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        providerSort = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ProviderSort>(__rawJson, options);
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
                        providerSortConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ProviderSortConfig>(__rawJson, options);
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
                        responsesRequestProviderSortVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (providerSort == null && providerSortConfig == null && responsesRequestProviderSortVariant3 == null)
            {
                try
                {
                    providerSort = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ProviderSort>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    providerSortConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ProviderSortConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responsesRequestProviderSortVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ResponsesRequestProviderSort(
                providerSort,

                providerSortConfig,

                responsesRequestProviderSortVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponsesRequestProviderSort value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsProviderSort)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ProviderSort, typeof(global::G.ProviderSort), options);
            }
            else if (value.IsProviderSortConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ProviderSortConfig, typeof(global::G.ProviderSortConfig), options);
            }
            else if (value.IsResponsesRequestProviderSortVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestProviderSortVariant3, typeof(object), options);
            }
        }
    }
}