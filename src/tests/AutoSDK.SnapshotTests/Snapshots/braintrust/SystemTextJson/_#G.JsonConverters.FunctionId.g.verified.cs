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

            global::G.FunctionIdFunctionId1? value1 = default;
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdFunctionId1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdFunctionId1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdFunctionId1).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdProjectSlug), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdProjectSlug> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdProjectSlug).Name}");
                        projectSlug = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdGlobalFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdGlobalFunction> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdGlobalFunction).Name}");
                        globalFunction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdPromptSessionId), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdPromptSessionId> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdPromptSessionId).Name}");
                        promptSessionId = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdInlineCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdInlineCode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdInlineCode).Name}");
                        inlineCode = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdInlineFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdInlineFunction> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdInlineFunction).Name}");
                        inlineFunction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdInlinePrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdInlinePrompt> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdInlinePrompt).Name}");
                        inlinePrompt = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && projectSlug == null && globalFunction == null && promptSessionId == null && inlineCode == null && inlineFunction == null && inlinePrompt == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdFunctionId1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdFunctionId1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdFunctionId1).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdProjectSlug), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdProjectSlug> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdProjectSlug).Name}");
                    projectSlug = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdGlobalFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdGlobalFunction> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdGlobalFunction).Name}");
                    globalFunction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdPromptSessionId), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdPromptSessionId> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdPromptSessionId).Name}");
                    promptSessionId = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdInlineCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdInlineCode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdInlineCode).Name}");
                    inlineCode = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdInlineFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdInlineFunction> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdInlineFunction).Name}");
                    inlineFunction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdInlinePrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdInlinePrompt> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdInlinePrompt).Name}");
                    inlinePrompt = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FunctionId(
                value1,

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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdFunctionId1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdFunctionId1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdFunctionId1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!, typeInfo);
            }
            else if (value.IsProjectSlug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdProjectSlug), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdProjectSlug?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdProjectSlug).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ProjectSlug!, typeInfo);
            }
            else if (value.IsGlobalFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdGlobalFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdGlobalFunction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdGlobalFunction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GlobalFunction!, typeInfo);
            }
            else if (value.IsPromptSessionId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdPromptSessionId), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdPromptSessionId?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdPromptSessionId).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PromptSessionId!, typeInfo);
            }
            else if (value.IsInlineCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdInlineCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdInlineCode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdInlineCode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InlineCode!, typeInfo);
            }
            else if (value.IsInlineFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdInlineFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdInlineFunction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdInlineFunction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InlineFunction!, typeInfo);
            }
            else if (value.IsInlinePrompt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionIdInlinePrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionIdInlinePrompt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionIdInlinePrompt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InlinePrompt!, typeInfo);
            }
        }
    }
}