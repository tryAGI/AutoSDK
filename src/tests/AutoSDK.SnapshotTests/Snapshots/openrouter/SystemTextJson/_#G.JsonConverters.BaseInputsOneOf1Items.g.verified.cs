//HintName: G.JsonConverters.BaseInputsOneOf1Items.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseInputsOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseInputsOneOf1Items>
    {
        /// <inheritdoc />
        public override global::G.BaseInputsOneOf1Items Read(
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
            if (__jsonProps.Contains("phase")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("call_id")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("output")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("arguments")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("result")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("content")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("phase")) __score5++;
            if (__jsonProps.Contains("role")) __score5++;
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

            global::G.BaseInputsOneOf1Items0? baseInputsOneOf1Items0 = default;
            global::G.BaseInputsOneOf1Items1? baseInputsOneOf1Items1 = default;
            global::G.BaseInputsOneOf1Items2? baseInputsOneOf1Items2 = default;
            global::G.BaseInputsOneOf1Items3? baseInputsOneOf1Items3 = default;
            global::G.OutputItemImageGenerationCall? outputItemImageGenerationCall = default;
            global::G.OutputMessage? outputMessage = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        baseInputsOneOf1Items0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1Items0>(__rawJson, options);
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
                        baseInputsOneOf1Items1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1Items1>(__rawJson, options);
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
                        baseInputsOneOf1Items2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1Items2>(__rawJson, options);
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
                        baseInputsOneOf1Items3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1Items3>(__rawJson, options);
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
                        outputItemImageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemImageGenerationCall>(__rawJson, options);
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
                        outputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessage>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseInputsOneOf1Items0 == null && baseInputsOneOf1Items1 == null && baseInputsOneOf1Items2 == null && baseInputsOneOf1Items3 == null && outputItemImageGenerationCall == null && outputMessage == null)
            {
                try
                {
                    baseInputsOneOf1Items0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1Items0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseInputsOneOf1Items1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1Items1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseInputsOneOf1Items2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1Items2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseInputsOneOf1Items3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1Items3>(__rawJson, options);
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

            var __value = new global::G.BaseInputsOneOf1Items(
                baseInputsOneOf1Items0,

                baseInputsOneOf1Items1,

                baseInputsOneOf1Items2,

                baseInputsOneOf1Items3,

                outputItemImageGenerationCall,

                outputMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseInputsOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBaseInputsOneOf1Items0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseInputsOneOf1Items0, typeof(global::G.BaseInputsOneOf1Items0), options);
            }
            else if (value.IsBaseInputsOneOf1Items1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseInputsOneOf1Items1, typeof(global::G.BaseInputsOneOf1Items1), options);
            }
            else if (value.IsBaseInputsOneOf1Items2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseInputsOneOf1Items2, typeof(global::G.BaseInputsOneOf1Items2), options);
            }
            else if (value.IsBaseInputsOneOf1Items3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseInputsOneOf1Items3, typeof(global::G.BaseInputsOneOf1Items3), options);
            }
            else if (value.IsOutputItemImageGenerationCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemImageGenerationCall, typeof(global::G.OutputItemImageGenerationCall), options);
            }
            else if (value.IsOutputMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessage, typeof(global::G.OutputMessage), options);
            }
        }
    }
}