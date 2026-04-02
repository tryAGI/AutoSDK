//HintName: G.JsonConverters.InputsOneOf1Items.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputsOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputsOneOf1Items>
    {
        /// <inheritdoc />
        public override global::G.InputsOneOf1Items Read(
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
            if (__jsonProps.Contains("encrypted_content")) __score0++;
            if (__jsonProps.Contains("format")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("signature")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("summary")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("phase")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("arguments")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("call_id")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("output")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("content")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("phase")) __score5++;
            if (__jsonProps.Contains("role")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("content")) __score6++;
            if (__jsonProps.Contains("encrypted_content")) __score6++;
            if (__jsonProps.Contains("format")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("signature")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("summary")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("arguments")) __score7++;
            if (__jsonProps.Contains("call_id")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("status")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("action")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("queries")) __score9++;
            if (__jsonProps.Contains("status")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("result")) __score10++;
            if (__jsonProps.Contains("status")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("datetime")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("status")) __score11++;
            if (__jsonProps.Contains("timezone")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("status")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
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
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::G.ReasoningItem? reasoningItem = default;
            global::G.EasyInputMessage? easyInputMessage = default;
            global::G.InputMessageItem? inputMessageItem = default;
            global::G.FunctionCallItem? functionCallItem = default;
            global::G.FunctionCallOutputItem? functionCallOutputItem = default;
            global::G.InputsOneOf1Items5? inputsOneOf1Items5 = default;
            global::G.InputsOneOf1Items6? inputsOneOf1Items6 = default;
            global::G.OutputFunctionCallItem? outputFunctionCallItem = default;
            global::G.OutputWebSearchCallItem? outputWebSearchCallItem = default;
            global::G.OutputFileSearchCallItem? outputFileSearchCallItem = default;
            global::G.OutputImageGenerationCallItem? outputImageGenerationCallItem = default;
            global::G.OutputDatetimeItem? outputDatetimeItem = default;
            global::G.OutputServerToolItem? outputServerToolItem = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        reasoningItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReasoningItem>(__rawJson, options);
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
                        easyInputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessage>(__rawJson, options);
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
                        inputMessageItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageItem>(__rawJson, options);
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
                        functionCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionCallItem>(__rawJson, options);
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
                        functionCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionCallOutputItem>(__rawJson, options);
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
                        inputsOneOf1Items5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputsOneOf1Items5>(__rawJson, options);
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
                        inputsOneOf1Items6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputsOneOf1Items6>(__rawJson, options);
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
                        outputFunctionCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputFunctionCallItem>(__rawJson, options);
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
                        outputWebSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputWebSearchCallItem>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
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
                else if (__bestIndex == 10)
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
                else if (__bestIndex == 11)
                {
                    try
                    {
                        outputDatetimeItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputDatetimeItem>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && inputsOneOf1Items5 == null && inputsOneOf1Items6 == null && outputFunctionCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputDatetimeItem == null && outputServerToolItem == null)
            {
                try
                {
                    reasoningItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReasoningItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    easyInputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputMessageItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionCallItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionCallItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionCallOutputItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputsOneOf1Items5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputsOneOf1Items5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputsOneOf1Items6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputsOneOf1Items6>(__rawJson, options);
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
                    outputDatetimeItem = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputDatetimeItem>(__rawJson, options);
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

            var __value = new global::G.InputsOneOf1Items(
                reasoningItem,

                easyInputMessage,

                inputMessageItem,

                functionCallItem,

                functionCallOutputItem,

                inputsOneOf1Items5,

                inputsOneOf1Items6,

                outputFunctionCallItem,

                outputWebSearchCallItem,

                outputFileSearchCallItem,

                outputImageGenerationCallItem,

                outputDatetimeItem,

                outputServerToolItem
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputsOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsReasoningItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningItem, typeof(global::G.ReasoningItem), options);
            }
            else if (value.IsEasyInputMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessage, typeof(global::G.EasyInputMessage), options);
            }
            else if (value.IsInputMessageItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessageItem, typeof(global::G.InputMessageItem), options);
            }
            else if (value.IsFunctionCallItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallItem, typeof(global::G.FunctionCallItem), options);
            }
            else if (value.IsFunctionCallOutputItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutputItem, typeof(global::G.FunctionCallOutputItem), options);
            }
            else if (value.IsInputsOneOf1Items5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1Items5, typeof(global::G.InputsOneOf1Items5), options);
            }
            else if (value.IsInputsOneOf1Items6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1Items6, typeof(global::G.InputsOneOf1Items6), options);
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
            else if (value.IsOutputDatetimeItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputDatetimeItem, typeof(global::G.OutputDatetimeItem), options);
            }
            else if (value.IsOutputServerToolItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputServerToolItem, typeof(global::G.OutputServerToolItem), options);
            }
        }
    }
}