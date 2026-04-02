//HintName: G.JsonConverters.BaseResponsesResultOutputItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseResponsesResultOutputItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseResponsesResultOutputItems>
    {
        /// <inheritdoc />
        public override global::G.BaseResponsesResultOutputItems Read(
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
            if (__jsonProps.Contains("id")) __score1++;
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.OutputMessage? outputMessage = default;
            global::G.OutputItemReasoning? outputItemReasoning = default;
            global::G.OutputItemFunctionCall? outputItemFunctionCall = default;
            global::G.OutputItemWebSearchCall? outputItemWebSearchCall = default;
            global::G.OutputItemFileSearchCall? outputItemFileSearchCall = default;
            global::G.OutputItemImageGenerationCall? outputItemImageGenerationCall = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        outputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessage>(__rawJson, options);
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
                        outputItemReasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemReasoning>(__rawJson, options);
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
                        outputItemFunctionCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemFunctionCall>(__rawJson, options);
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
                        outputItemWebSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemWebSearchCall>(__rawJson, options);
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
                        outputItemFileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemFileSearchCall>(__rawJson, options);
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
                        outputItemImageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemImageGenerationCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputMessage == null && outputItemReasoning == null && outputItemFunctionCall == null && outputItemWebSearchCall == null && outputItemFileSearchCall == null && outputItemImageGenerationCall == null)
            {
                try
                {
                    outputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputItemReasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemReasoning>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputItemFunctionCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemFunctionCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputItemWebSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemWebSearchCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputItemFileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemFileSearchCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputItemImageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemImageGenerationCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseResponsesResultOutputItems(
                outputMessage,

                outputItemReasoning,

                outputItemFunctionCall,

                outputItemWebSearchCall,

                outputItemFileSearchCall,

                outputItemImageGenerationCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseResponsesResultOutputItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOutputMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessage, typeof(global::G.OutputMessage), options);
            }
            else if (value.IsOutputItemReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemReasoning, typeof(global::G.OutputItemReasoning), options);
            }
            else if (value.IsOutputItemFunctionCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemFunctionCall, typeof(global::G.OutputItemFunctionCall), options);
            }
            else if (value.IsOutputItemWebSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemWebSearchCall, typeof(global::G.OutputItemWebSearchCall), options);
            }
            else if (value.IsOutputItemFileSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemFileSearchCall, typeof(global::G.OutputItemFileSearchCall), options);
            }
            else if (value.IsOutputItemImageGenerationCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemImageGenerationCall, typeof(global::G.OutputItemImageGenerationCall), options);
            }
        }
    }
}