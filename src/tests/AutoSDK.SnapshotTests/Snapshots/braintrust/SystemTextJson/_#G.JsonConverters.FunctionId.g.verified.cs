//HintName: G.JsonConverters.FunctionId.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FunctionIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FunctionId>
    {
        /// <inheritdoc />
        public override global::G.FunctionId Read(
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
            if (__jsonProps.Contains("function_id")) __score0++;
            if (__jsonProps.Contains("version")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("project_name")) __score1++;
            if (__jsonProps.Contains("slug")) __score1++;
            if (__jsonProps.Contains("version")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("function_type")) __score2++;
            if (__jsonProps.Contains("global_function")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("prompt_session_function_id")) __score3++;
            if (__jsonProps.Contains("prompt_session_id")) __score3++;
            if (__jsonProps.Contains("version")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("code")) __score4++;
            if (__jsonProps.Contains("inline_context")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("function_type")) __score5++;
            if (__jsonProps.Contains("inline_function")) __score5++;
            if (__jsonProps.Contains("inline_prompt")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("function_type")) __score6++;
            if (__jsonProps.Contains("inline_prompt")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::G.FunctionIdFunctionId1? id1 = default;
            global::G.FunctionIdProjectSlug? projectSlug = default;
            global::G.FunctionIdGlobalFunction? globalFunction = default;
            global::G.FunctionIdPromptSessionId? promptSessionId = default;
            global::G.FunctionIdInlineCode? inlineCode = default;
            global::G.FunctionIdInlineFunction? inlineFunction = default;
            global::G.FunctionIdInlinePrompt? inlinePrompt = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        id1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdFunctionId1>(__rawJson, options);
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
                        projectSlug = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdProjectSlug>(__rawJson, options);
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
                        globalFunction = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdGlobalFunction>(__rawJson, options);
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
                        promptSessionId = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdPromptSessionId>(__rawJson, options);
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
                        inlineCode = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdInlineCode>(__rawJson, options);
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
                        inlineFunction = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdInlineFunction>(__rawJson, options);
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
                        inlinePrompt = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdInlinePrompt>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (id1 == null && projectSlug == null && globalFunction == null && promptSessionId == null && inlineCode == null && inlineFunction == null && inlinePrompt == null)
            {
                try
                {
                    id1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdFunctionId1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    projectSlug = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdProjectSlug>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    globalFunction = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdGlobalFunction>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    promptSessionId = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdPromptSessionId>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inlineCode = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdInlineCode>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inlineFunction = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdInlineFunction>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inlinePrompt = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionIdInlinePrompt>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FunctionId(
                id1,

                projectSlug,

                globalFunction,

                promptSessionId,

                inlineCode,

                inlineFunction,

                inlinePrompt
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FunctionId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsId1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Id1, typeof(global::G.FunctionIdFunctionId1), options);
            }
            else if (value.IsProjectSlug)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ProjectSlug, typeof(global::G.FunctionIdProjectSlug), options);
            }
            else if (value.IsGlobalFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GlobalFunction, typeof(global::G.FunctionIdGlobalFunction), options);
            }
            else if (value.IsPromptSessionId)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PromptSessionId, typeof(global::G.FunctionIdPromptSessionId), options);
            }
            else if (value.IsInlineCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InlineCode, typeof(global::G.FunctionIdInlineCode), options);
            }
            else if (value.IsInlineFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InlineFunction, typeof(global::G.FunctionIdInlineFunction), options);
            }
            else if (value.IsInlinePrompt)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InlinePrompt, typeof(global::G.FunctionIdInlinePrompt), options);
            }
        }
    }
}