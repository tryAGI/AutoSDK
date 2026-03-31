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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningItem).Name}");
                        reasoningItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessage).Name}");
                        easyInputMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessageItem).Name}");
                        inputMessageItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionCallItem).Name}");
                        functionCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallOutputItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionCallOutputItem).Name}");
                        functionCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputsOneOf1Items5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputsOneOf1Items5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputsOneOf1Items5).Name}");
                        inputsOneOf1Items5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputsOneOf1Items6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputsOneOf1Items6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputsOneOf1Items6).Name}");
                        inputsOneOf1Items6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFunctionCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFunctionCallItem).Name}");
                        outputFunctionCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputWebSearchCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputWebSearchCallItem).Name}");
                        outputWebSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFileSearchCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFileSearchCallItem).Name}");
                        outputFileSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputImageGenerationCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputImageGenerationCallItem).Name}");
                        outputImageGenerationCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputDatetimeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputDatetimeItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputDatetimeItem).Name}");
                        outputDatetimeItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputServerToolItem).Name}");
                        outputServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningItem).Name}");
                    reasoningItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessage).Name}");
                    easyInputMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessageItem).Name}");
                    inputMessageItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionCallItem).Name}");
                    functionCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallOutputItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionCallOutputItem).Name}");
                    functionCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputsOneOf1Items5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputsOneOf1Items5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputsOneOf1Items5).Name}");
                    inputsOneOf1Items5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputsOneOf1Items6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputsOneOf1Items6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputsOneOf1Items6).Name}");
                    inputsOneOf1Items6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFunctionCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFunctionCallItem).Name}");
                    outputFunctionCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputWebSearchCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputWebSearchCallItem).Name}");
                    outputWebSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFileSearchCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFileSearchCallItem).Name}");
                    outputFileSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputImageGenerationCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputImageGenerationCallItem).Name}");
                    outputImageGenerationCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputDatetimeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputDatetimeItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputDatetimeItem).Name}");
                    outputDatetimeItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputServerToolItem).Name}");
                    outputServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReasoningItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningItem!, typeInfo);
            }
            else if (value.IsEasyInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessage!, typeInfo);
            }
            else if (value.IsInputMessageItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessageItem!, typeInfo);
            }
            else if (value.IsFunctionCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallItem!, typeInfo);
            }
            else if (value.IsFunctionCallOutputItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallOutputItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionCallOutputItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutputItem!, typeInfo);
            }
            else if (value.IsInputsOneOf1Items5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputsOneOf1Items5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputsOneOf1Items5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputsOneOf1Items5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1Items5!, typeInfo);
            }
            else if (value.IsInputsOneOf1Items6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputsOneOf1Items6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputsOneOf1Items6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputsOneOf1Items6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1Items6!, typeInfo);
            }
            else if (value.IsOutputFunctionCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFunctionCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFunctionCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputFunctionCallItem!, typeInfo);
            }
            else if (value.IsOutputWebSearchCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputWebSearchCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputWebSearchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputWebSearchCallItem!, typeInfo);
            }
            else if (value.IsOutputFileSearchCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFileSearchCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFileSearchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputFileSearchCallItem!, typeInfo);
            }
            else if (value.IsOutputImageGenerationCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputImageGenerationCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputImageGenerationCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputImageGenerationCallItem!, typeInfo);
            }
            else if (value.IsOutputDatetimeItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputDatetimeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputDatetimeItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputDatetimeItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputDatetimeItem!, typeInfo);
            }
            else if (value.IsOutputServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputServerToolItem!, typeInfo);
            }
        }
    }
}