//HintName: G.JsonConverters.CreateChatCompletionRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateChatCompletionRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateChatCompletionRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateChatCompletionRequest Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("audio")) __score1++;
            if (__jsonProps.Contains("frequency_penalty")) __score1++;
            if (__jsonProps.Contains("function_call")) __score1++;
            if (__jsonProps.Contains("functions")) __score1++;
            if (__jsonProps.Contains("logit_bias")) __score1++;
            if (__jsonProps.Contains("logprobs")) __score1++;
            if (__jsonProps.Contains("max_completion_tokens")) __score1++;
            if (__jsonProps.Contains("max_tokens")) __score1++;
            if (__jsonProps.Contains("messages")) __score1++;
            if (__jsonProps.Contains("modalities")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("n")) __score1++;
            if (__jsonProps.Contains("parallel_tool_calls")) __score1++;
            if (__jsonProps.Contains("prediction")) __score1++;
            if (__jsonProps.Contains("presence_penalty")) __score1++;
            if (__jsonProps.Contains("reasoning_effort")) __score1++;
            if (__jsonProps.Contains("response_format")) __score1++;
            if (__jsonProps.Contains("seed")) __score1++;
            if (__jsonProps.Contains("stop")) __score1++;
            if (__jsonProps.Contains("store")) __score1++;
            if (__jsonProps.Contains("stream")) __score1++;
            if (__jsonProps.Contains("stream_options")) __score1++;
            if (__jsonProps.Contains("tool_choice")) __score1++;
            if (__jsonProps.Contains("tools")) __score1++;
            if (__jsonProps.Contains("top_logprobs")) __score1++;
            if (__jsonProps.Contains("web_search_options")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.CreateModelResponseProperties? modelResponseProperties = default;
            global::G.CreateChatCompletionRequestVariant2? createChatCompletionRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        modelResponseProperties = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateModelResponseProperties>(__rawJson, options);
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
                        createChatCompletionRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateChatCompletionRequestVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (modelResponseProperties == null && createChatCompletionRequestVariant2 == null)
            {
                try
                {
                    modelResponseProperties = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateModelResponseProperties>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    createChatCompletionRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateChatCompletionRequestVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateChatCompletionRequest(
                modelResponseProperties,

                createChatCompletionRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateChatCompletionRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsModelResponseProperties)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelResponseProperties, typeof(global::G.CreateModelResponseProperties), options);
            }
            else if (value.IsCreateChatCompletionRequestVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateChatCompletionRequestVariant2, typeof(global::G.CreateChatCompletionRequestVariant2), options);
            }
        }
    }
}