//HintName: G.JsonConverters.ResponsesRequestPluginsItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesRequestPluginsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponsesRequestPluginsItems>
    {
        /// <inheritdoc />
        public override global::G.ResponsesRequestPluginsItems Read(
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
            if (__jsonProps.Contains("allowed_models")) __score0++;
            if (__jsonProps.Contains("enabled")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("enabled")) __score2++;
            if (__jsonProps.Contains("engine")) __score2++;
            if (__jsonProps.Contains("exclude_domains")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("include_domains")) __score2++;
            if (__jsonProps.Contains("max_results")) __score2++;
            if (__jsonProps.Contains("search_prompt")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("enabled")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("pdf")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("enabled")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("enabled")) __score5++;
            if (__jsonProps.Contains("engine")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.ResponsesRequestPluginsItems0? responsesRequestPluginsItems0 = default;
            global::G.ResponsesRequestPluginsItems1? responsesRequestPluginsItems1 = default;
            global::G.ResponsesRequestPluginsItems2? responsesRequestPluginsItems2 = default;
            global::G.ResponsesRequestPluginsItems3? responsesRequestPluginsItems3 = default;
            global::G.ResponsesRequestPluginsItems4? responsesRequestPluginsItems4 = default;
            global::G.ResponsesRequestPluginsItems5? responsesRequestPluginsItems5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        responsesRequestPluginsItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems0>(__rawJson, options);
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
                        responsesRequestPluginsItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems1>(__rawJson, options);
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
                        responsesRequestPluginsItems2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems2>(__rawJson, options);
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
                        responsesRequestPluginsItems3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems3>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        responsesRequestPluginsItems4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems4>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        responsesRequestPluginsItems5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems5>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responsesRequestPluginsItems0 == null && responsesRequestPluginsItems1 == null && responsesRequestPluginsItems2 == null && responsesRequestPluginsItems3 == null && responsesRequestPluginsItems4 == null && responsesRequestPluginsItems5 == null)
            {
                try
                {
                    responsesRequestPluginsItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responsesRequestPluginsItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responsesRequestPluginsItems2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responsesRequestPluginsItems3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responsesRequestPluginsItems4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responsesRequestPluginsItems5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestPluginsItems5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ResponsesRequestPluginsItems(
                responsesRequestPluginsItems0,

                responsesRequestPluginsItems1,

                responsesRequestPluginsItems2,

                responsesRequestPluginsItems3,

                responsesRequestPluginsItems4,

                responsesRequestPluginsItems5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponsesRequestPluginsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsResponsesRequestPluginsItems0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItems0, typeof(global::G.ResponsesRequestPluginsItems0), options);
            }
            else if (value.IsResponsesRequestPluginsItems1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItems1, typeof(global::G.ResponsesRequestPluginsItems1), options);
            }
            else if (value.IsResponsesRequestPluginsItems2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItems2, typeof(global::G.ResponsesRequestPluginsItems2), options);
            }
            else if (value.IsResponsesRequestPluginsItems3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItems3, typeof(global::G.ResponsesRequestPluginsItems3), options);
            }
            else if (value.IsResponsesRequestPluginsItems4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItems4, typeof(global::G.ResponsesRequestPluginsItems4), options);
            }
            else if (value.IsResponsesRequestPluginsItems5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItems5, typeof(global::G.ResponsesRequestPluginsItems5), options);
            }
        }
    }
}