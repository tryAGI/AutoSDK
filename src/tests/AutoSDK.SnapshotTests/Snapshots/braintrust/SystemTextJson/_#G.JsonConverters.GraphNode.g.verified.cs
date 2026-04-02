//HintName: G.JsonConverters.GraphNode.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GraphNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GraphNode>
    {
        /// <inheritdoc />
        public override global::G.GraphNode Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("function")) __score0++;
            if (__jsonProps.Contains("position")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("position")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("position")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("description")) __score3++;
            if (__jsonProps.Contains("position")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("description")) __score4++;
            if (__jsonProps.Contains("expr")) __score4++;
            if (__jsonProps.Contains("position")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("condition")) __score5++;
            if (__jsonProps.Contains("description")) __score5++;
            if (__jsonProps.Contains("position")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("description")) __score6++;
            if (__jsonProps.Contains("position")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("description")) __score7++;
            if (__jsonProps.Contains("position")) __score7++;
            if (__jsonProps.Contains("prompt")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
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

            global::G.GraphNodeVariant1? graphNodeVariant1 = default;
            global::G.GraphNodeVariant2? graphNodeVariant2 = default;
            global::G.GraphNodeVariant3? graphNodeVariant3 = default;
            global::G.GraphNodeVariant4? graphNodeVariant4 = default;
            global::G.GraphNodeVariant5? graphNodeVariant5 = default;
            global::G.GraphNodeVariant6? graphNodeVariant6 = default;
            global::G.GraphNodeVariant7? graphNodeVariant7 = default;
            global::G.GraphNodeVariant8? graphNodeVariant8 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        graphNodeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant1>(__rawJson, options);
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
                        graphNodeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant2>(__rawJson, options);
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
                        graphNodeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant3>(__rawJson, options);
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
                        graphNodeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant4>(__rawJson, options);
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
                        graphNodeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant5>(__rawJson, options);
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
                        graphNodeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant6>(__rawJson, options);
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
                        graphNodeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant7>(__rawJson, options);
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
                        graphNodeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant8>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (graphNodeVariant1 == null && graphNodeVariant2 == null && graphNodeVariant3 == null && graphNodeVariant4 == null && graphNodeVariant5 == null && graphNodeVariant6 == null && graphNodeVariant7 == null && graphNodeVariant8 == null)
            {
                try
                {
                    graphNodeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    graphNodeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    graphNodeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    graphNodeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    graphNodeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    graphNodeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant6>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    graphNodeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant7>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    graphNodeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraphNodeVariant8>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.GraphNode(
                graphNodeVariant1,

                graphNodeVariant2,

                graphNodeVariant3,

                graphNodeVariant4,

                graphNodeVariant5,

                graphNodeVariant6,

                graphNodeVariant7,

                graphNodeVariant8
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GraphNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsGraphNodeVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant1, typeof(global::G.GraphNodeVariant1), options);
            }
            else if (value.IsGraphNodeVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant2, typeof(global::G.GraphNodeVariant2), options);
            }
            else if (value.IsGraphNodeVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant3, typeof(global::G.GraphNodeVariant3), options);
            }
            else if (value.IsGraphNodeVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant4, typeof(global::G.GraphNodeVariant4), options);
            }
            else if (value.IsGraphNodeVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant5, typeof(global::G.GraphNodeVariant5), options);
            }
            else if (value.IsGraphNodeVariant6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant6, typeof(global::G.GraphNodeVariant6), options);
            }
            else if (value.IsGraphNodeVariant7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant7, typeof(global::G.GraphNodeVariant7), options);
            }
            else if (value.IsGraphNodeVariant8)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant8, typeof(global::G.GraphNodeVariant8), options);
            }
        }
    }
}