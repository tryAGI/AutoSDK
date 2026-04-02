//HintName: G.JsonConverters.OutputItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputItems>
    {
        /// <inheritdoc />
        public override global::G.OutputItems Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("phase")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("encrypted_content")) __score1++;
            if (__jsonProps.Contains("format")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("signature")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("summary")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("arguments")) __score2++;
            if (__jsonProps.Contains("call_id")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("action")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("queries")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("result")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::G.OutputMessageItem? outputMessageItem = default;
            global::G.OutputReasoningItem? outputReasoningItem = default;
            global::G.OutputFunctionCallItem? outputFunctionCallItem = default;
            global::G.OutputWebSearchCallItem? outputWebSearchCallItem = default;
            global::G.OutputFileSearchCallItem? outputFileSearchCallItem = default;
            global::G.OutputImageGenerationCallItem? outputImageGenerationCallItem = default;
            global::G.OutputServerToolItem? outputServerToolItem = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        outputMessageItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessageItem>(__rawJson, options);
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
                        outputReasoningItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputReasoningItem>(__rawJson, options);
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
                        outputFunctionCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputFunctionCallItem>(__rawJson, options);
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
                        outputWebSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputWebSearchCallItem>(__rawJson, options);
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
                        outputFileSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputFileSearchCallItem>(__rawJson, options);
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
                        outputImageGenerationCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputImageGenerationCallItem>(__rawJson, options);
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
                        outputServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputServerToolItem>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputMessageItem == null && outputReasoningItem == null && outputFunctionCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputServerToolItem == null)
            {
                try
                {
                    outputMessageItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessageItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputReasoningItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputReasoningItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputFunctionCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputFunctionCallItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputWebSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputWebSearchCallItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputFileSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputFileSearchCallItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputImageGenerationCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputImageGenerationCallItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputServerToolItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OutputItems(
                outputMessageItem,

                outputReasoningItem,

                outputFunctionCallItem,

                outputWebSearchCallItem,

                outputFileSearchCallItem,

                outputImageGenerationCallItem,

                outputServerToolItem
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOutputMessageItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessageItem, typeof(global::G.OutputMessageItem), options);
            }
            else if (value.IsOutputReasoningItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputReasoningItem, typeof(global::G.OutputReasoningItem), options);
            }
            else if (value.IsOutputFunctionCallItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputFunctionCallItem, typeof(global::G.OutputFunctionCallItem), options);
            }
            else if (value.IsOutputWebSearchCallItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputWebSearchCallItem, typeof(global::G.OutputWebSearchCallItem), options);
            }
            else if (value.IsOutputFileSearchCallItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputFileSearchCallItem, typeof(global::G.OutputFileSearchCallItem), options);
            }
            else if (value.IsOutputImageGenerationCallItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputImageGenerationCallItem, typeof(global::G.OutputImageGenerationCallItem), options);
            }
            else if (value.IsOutputServerToolItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputServerToolItem, typeof(global::G.OutputServerToolItem), options);
            }
        }
    }
}