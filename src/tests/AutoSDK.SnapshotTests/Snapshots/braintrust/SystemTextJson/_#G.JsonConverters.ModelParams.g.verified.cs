//HintName: G.JsonConverters.ModelParams.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ModelParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ModelParams>
    {
        /// <inheritdoc />
        public override global::G.ModelParams Read(
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
            if (__jsonProps.Contains("frequency_penalty")) __score0++;
            if (__jsonProps.Contains("function_call")) __score0++;
            if (__jsonProps.Contains("max_completion_tokens")) __score0++;
            if (__jsonProps.Contains("max_tokens")) __score0++;
            if (__jsonProps.Contains("n")) __score0++;
            if (__jsonProps.Contains("presence_penalty")) __score0++;
            if (__jsonProps.Contains("reasoning_budget")) __score0++;
            if (__jsonProps.Contains("reasoning_effort")) __score0++;
            if (__jsonProps.Contains("reasoning_enabled")) __score0++;
            if (__jsonProps.Contains("response_format")) __score0++;
            if (__jsonProps.Contains("stop")) __score0++;
            if (__jsonProps.Contains("temperature")) __score0++;
            if (__jsonProps.Contains("tool_choice")) __score0++;
            if (__jsonProps.Contains("top_p")) __score0++;
            if (__jsonProps.Contains("use_cache")) __score0++;
            if (__jsonProps.Contains("verbosity")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("max_tokens")) __score1++;
            if (__jsonProps.Contains("max_tokens_to_sample")) __score1++;
            if (__jsonProps.Contains("reasoning_budget")) __score1++;
            if (__jsonProps.Contains("reasoning_enabled")) __score1++;
            if (__jsonProps.Contains("stop_sequences")) __score1++;
            if (__jsonProps.Contains("temperature")) __score1++;
            if (__jsonProps.Contains("top_k")) __score1++;
            if (__jsonProps.Contains("top_p")) __score1++;
            if (__jsonProps.Contains("use_cache")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("maxOutputTokens")) __score2++;
            if (__jsonProps.Contains("reasoning_budget")) __score2++;
            if (__jsonProps.Contains("reasoning_enabled")) __score2++;
            if (__jsonProps.Contains("temperature")) __score2++;
            if (__jsonProps.Contains("topK")) __score2++;
            if (__jsonProps.Contains("topP")) __score2++;
            if (__jsonProps.Contains("use_cache")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("reasoning_budget")) __score3++;
            if (__jsonProps.Contains("reasoning_enabled")) __score3++;
            if (__jsonProps.Contains("temperature")) __score3++;
            if (__jsonProps.Contains("topK")) __score3++;
            if (__jsonProps.Contains("use_cache")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("reasoning_budget")) __score4++;
            if (__jsonProps.Contains("reasoning_enabled")) __score4++;
            if (__jsonProps.Contains("use_cache")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.ModelParamsOpenAIModelParams? openAIModelParams = default;
            global::G.ModelParamsAnthropicModelParams? anthropicModelParams = default;
            global::G.ModelParamsGoogleModelParams? googleModelParams = default;
            global::G.ModelParamsWindowAIModelParams? windowAIModelParams = default;
            global::G.ModelParamsJsCompletionParams? jsCompletionParams = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsOpenAIModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsOpenAIModelParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsOpenAIModelParams).Name}");
                        openAIModelParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsAnthropicModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsAnthropicModelParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsAnthropicModelParams).Name}");
                        anthropicModelParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsGoogleModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsGoogleModelParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsGoogleModelParams).Name}");
                        googleModelParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsWindowAIModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsWindowAIModelParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsWindowAIModelParams).Name}");
                        windowAIModelParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsJsCompletionParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsJsCompletionParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsJsCompletionParams).Name}");
                        jsCompletionParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (openAIModelParams == null && anthropicModelParams == null && googleModelParams == null && windowAIModelParams == null && jsCompletionParams == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsOpenAIModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsOpenAIModelParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsOpenAIModelParams).Name}");
                    openAIModelParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsAnthropicModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsAnthropicModelParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsAnthropicModelParams).Name}");
                    anthropicModelParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsGoogleModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsGoogleModelParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsGoogleModelParams).Name}");
                    googleModelParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsWindowAIModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsWindowAIModelParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsWindowAIModelParams).Name}");
                    windowAIModelParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsJsCompletionParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsJsCompletionParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsJsCompletionParams).Name}");
                    jsCompletionParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ModelParams(
                openAIModelParams,

                anthropicModelParams,

                googleModelParams,

                windowAIModelParams,

                jsCompletionParams
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ModelParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenAIModelParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsOpenAIModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsOpenAIModelParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsOpenAIModelParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIModelParams!, typeInfo);
            }
            else if (value.IsAnthropicModelParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsAnthropicModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsAnthropicModelParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsAnthropicModelParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicModelParams!, typeInfo);
            }
            else if (value.IsGoogleModelParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsGoogleModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsGoogleModelParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsGoogleModelParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleModelParams!, typeInfo);
            }
            else if (value.IsWindowAIModelParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsWindowAIModelParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsWindowAIModelParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsWindowAIModelParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WindowAIModelParams!, typeInfo);
            }
            else if (value.IsJsCompletionParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelParamsJsCompletionParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelParamsJsCompletionParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelParamsJsCompletionParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsCompletionParams!, typeInfo);
            }
        }
    }
}