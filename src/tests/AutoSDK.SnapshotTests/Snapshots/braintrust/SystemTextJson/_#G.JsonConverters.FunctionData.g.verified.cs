//HintName: G.JsonConverters.FunctionData.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FunctionDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FunctionData>
    {
        /// <inheritdoc />
        public override global::G.FunctionData Read(
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
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("edges")) __score2++;
            if (__jsonProps.Contains("nodes")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("endpoint")) __score3++;
            if (__jsonProps.Contains("eval_name")) __score3++;
            if (__jsonProps.Contains("parameters")) __score3++;
            if (__jsonProps.Contains("parameters_version")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("config")) __score4++;
            if (__jsonProps.Contains("function_type")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("embedding_model")) __score5++;
            if (__jsonProps.Contains("model")) __score5++;
            if (__jsonProps.Contains("no_match_pattern")) __score5++;
            if (__jsonProps.Contains("preprocessor")) __score5++;
            if (__jsonProps.Contains("prompt")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("facets")) __score6++;
            if (__jsonProps.Contains("preprocessor")) __score6++;
            if (__jsonProps.Contains("topic_maps")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("__schema")) __score7++;
            if (__jsonProps.Contains("data")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }

            global::G.FunctionDataPrompt? prompt = default;
            global::G.FunctionDataCode? code = default;
            global::G.GraphData? graph = default;
            global::G.FunctionDataRemoteEval? remoteEval = default;
            global::G.FunctionDataGlobal? global = default;
            global::G.FacetData? facet = default;
            global::G.BatchedFacetData? batchedFacet = default;
            global::G.FunctionDataParameters? parameters = default;
            global::G.AllOf<global::G.TopicMapData, object>? functionDataVariant9 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        prompt = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionDataPrompt>(__rawJson, options);
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
                        code = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionDataCode>(__rawJson, options);
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
                        graph = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphData>(__rawJson, options);
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
                        remoteEval = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionDataRemoteEval>(__rawJson, options);
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
                        global = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionDataGlobal>(__rawJson, options);
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
                        facet = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FacetData>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        batchedFacet = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BatchedFacetData>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        parameters = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionDataParameters>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        functionDataVariant9 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.TopicMapData, object>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (prompt == null && code == null && graph == null && remoteEval == null && global == null && facet == null && batchedFacet == null && parameters == null && functionDataVariant9 == null)
            {
                try
                {
                    prompt = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionDataPrompt>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    code = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionDataCode>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    graph = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphData>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    remoteEval = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionDataRemoteEval>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    global = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionDataGlobal>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    facet = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FacetData>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    batchedFacet = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BatchedFacetData>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    parameters = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionDataParameters>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionDataVariant9 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.TopicMapData, object>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FunctionData(
                prompt,

                code,

                graph,

                remoteEval,

                global,

                facet,

                batchedFacet,

                parameters,

                functionDataVariant9
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FunctionData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPrompt)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Prompt, typeof(global::G.FunctionDataPrompt), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::G.FunctionDataCode), options);
            }
            else if (value.IsGraph)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Graph, typeof(global::G.GraphData), options);
            }
            else if (value.IsRemoteEval)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemoteEval, typeof(global::G.FunctionDataRemoteEval), options);
            }
            else if (value.IsGlobal)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Global, typeof(global::G.FunctionDataGlobal), options);
            }
            else if (value.IsFacet)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Facet, typeof(global::G.FacetData), options);
            }
            else if (value.IsBatchedFacet)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BatchedFacet, typeof(global::G.BatchedFacetData), options);
            }
            else if (value.IsParameters)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Parameters, typeof(global::G.FunctionDataParameters), options);
            }
            else if (value.IsFunctionDataVariant9)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionDataVariant9, typeof(global::G.AllOf<global::G.TopicMapData, object>), options);
            }
        }
    }
}