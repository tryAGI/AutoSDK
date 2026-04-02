//HintName: G.JsonConverters.LLMConfigCreateDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class LLMConfigCreateDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LLMConfigCreateDto>
    {
        /// <inheritdoc />
        public override global::G.LLMConfigCreateDto Read(
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
            if (__jsonProps.Contains("instructions")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("prompt_customization")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            if (__jsonProps.Contains("temperature")) __score0++;
            if (__jsonProps.Contains("template")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("custom")) __score1++;
            if (__jsonProps.Contains("instructions")) __score1++;
            if (__jsonProps.Contains("prompt_customization")) __score1++;
            if (__jsonProps.Contains("provider")) __score1++;
            if (__jsonProps.Contains("temperature")) __score1++;
            if (__jsonProps.Contains("template")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("instructions")) __score2++;
            if (__jsonProps.Contains("prompt_customization")) __score2++;
            if (__jsonProps.Contains("secretId")) __score2++;
            if (__jsonProps.Contains("temperature")) __score2++;
            if (__jsonProps.Contains("template")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("instructions")) __score3++;
            if (__jsonProps.Contains("prompt_customization")) __score3++;
            if (__jsonProps.Contains("secretId")) __score3++;
            if (__jsonProps.Contains("temperature")) __score3++;
            if (__jsonProps.Contains("template")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("instructions")) __score4++;
            if (__jsonProps.Contains("model")) __score4++;
            if (__jsonProps.Contains("prompt_customization")) __score4++;
            if (__jsonProps.Contains("provider")) __score4++;
            if (__jsonProps.Contains("temperature")) __score4++;
            if (__jsonProps.Contains("template")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("instructions")) __score5++;
            if (__jsonProps.Contains("model")) __score5++;
            if (__jsonProps.Contains("prompt_customization")) __score5++;
            if (__jsonProps.Contains("provider")) __score5++;
            if (__jsonProps.Contains("temperature")) __score5++;
            if (__jsonProps.Contains("template")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.LLMConfigCreateDtoVariant1? lLMConfigCreateDtoVariant1 = default;
            global::G.LLMConfigCreateDtoVariant2? lLMConfigCreateDtoVariant2 = default;
            global::G.LLMConfigCreateDtoVariant3? lLMConfigCreateDtoVariant3 = default;
            global::G.LLMConfigCreateDtoVariant4? lLMConfigCreateDtoVariant4 = default;
            global::G.LLMConfigCreateDtoVariant5? lLMConfigCreateDtoVariant5 = default;
            global::G.LLMConfigCreateDtoVariant6? lLMConfigCreateDtoVariant6 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        lLMConfigCreateDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant1>(__rawJson, options);
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
                        lLMConfigCreateDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant2>(__rawJson, options);
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
                        lLMConfigCreateDtoVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant3>(__rawJson, options);
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
                        lLMConfigCreateDtoVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant4>(__rawJson, options);
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
                        lLMConfigCreateDtoVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant5>(__rawJson, options);
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
                        lLMConfigCreateDtoVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant6>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (lLMConfigCreateDtoVariant1 == null && lLMConfigCreateDtoVariant2 == null && lLMConfigCreateDtoVariant3 == null && lLMConfigCreateDtoVariant4 == null && lLMConfigCreateDtoVariant5 == null && lLMConfigCreateDtoVariant6 == null)
            {
                try
                {
                    lLMConfigCreateDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lLMConfigCreateDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lLMConfigCreateDtoVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lLMConfigCreateDtoVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lLMConfigCreateDtoVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lLMConfigCreateDtoVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMConfigCreateDtoVariant6>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.LLMConfigCreateDto(
                lLMConfigCreateDtoVariant1,

                lLMConfigCreateDtoVariant2,

                lLMConfigCreateDtoVariant3,

                lLMConfigCreateDtoVariant4,

                lLMConfigCreateDtoVariant5,

                lLMConfigCreateDtoVariant6
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LLMConfigCreateDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLLMConfigCreateDtoVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMConfigCreateDtoVariant1, typeof(global::G.LLMConfigCreateDtoVariant1), options);
            }
            else if (value.IsLLMConfigCreateDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMConfigCreateDtoVariant2, typeof(global::G.LLMConfigCreateDtoVariant2), options);
            }
            else if (value.IsLLMConfigCreateDtoVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMConfigCreateDtoVariant3, typeof(global::G.LLMConfigCreateDtoVariant3), options);
            }
            else if (value.IsLLMConfigCreateDtoVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMConfigCreateDtoVariant4, typeof(global::G.LLMConfigCreateDtoVariant4), options);
            }
            else if (value.IsLLMConfigCreateDtoVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMConfigCreateDtoVariant5, typeof(global::G.LLMConfigCreateDtoVariant5), options);
            }
            else if (value.IsLLMConfigCreateDtoVariant6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMConfigCreateDtoVariant6, typeof(global::G.LLMConfigCreateDtoVariant6), options);
            }
        }
    }
}