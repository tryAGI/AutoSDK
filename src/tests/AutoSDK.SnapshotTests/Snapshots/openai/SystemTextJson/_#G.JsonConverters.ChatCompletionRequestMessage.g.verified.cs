//HintName: G.JsonConverters.ChatCompletionRequestMessage.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionRequestMessage>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionRequestMessage Read(
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
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("audio")) __score3++;
            if (__jsonProps.Contains("content")) __score3++;
            if (__jsonProps.Contains("function_call")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("refusal")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            if (__jsonProps.Contains("tool_calls")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("content")) __score4++;
            if (__jsonProps.Contains("role")) __score4++;
            if (__jsonProps.Contains("tool_call_id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("content")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("role")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.ChatCompletionRequestDeveloperMessage? developerMessage = default;
            global::G.ChatCompletionRequestSystemMessage? systemMessage = default;
            global::G.ChatCompletionRequestUserMessage? userMessage = default;
            global::G.ChatCompletionRequestAssistantMessage? assistantMessage = default;
            global::G.ChatCompletionRequestToolMessage? toolMessage = default;
            global::G.ChatCompletionRequestFunctionMessage? functionMessage = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        developerMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestDeveloperMessage>(__rawJson, options);
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
                        systemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestSystemMessage>(__rawJson, options);
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
                        userMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestUserMessage>(__rawJson, options);
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
                        assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestAssistantMessage>(__rawJson, options);
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
                        toolMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestToolMessage>(__rawJson, options);
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
                        functionMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestFunctionMessage>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (developerMessage == null && systemMessage == null && userMessage == null && assistantMessage == null && toolMessage == null && functionMessage == null)
            {
                try
                {
                    developerMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestDeveloperMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    systemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestSystemMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    userMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestUserMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestAssistantMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestToolMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestFunctionMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatCompletionRequestMessage(
                developerMessage,

                systemMessage,

                userMessage,

                assistantMessage,

                toolMessage,

                functionMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionRequestMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsDeveloperMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeveloperMessage, typeof(global::G.ChatCompletionRequestDeveloperMessage), options);
            }
            else if (value.IsSystemMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeof(global::G.ChatCompletionRequestSystemMessage), options);
            }
            else if (value.IsUserMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeof(global::G.ChatCompletionRequestUserMessage), options);
            }
            else if (value.IsAssistantMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeof(global::G.ChatCompletionRequestAssistantMessage), options);
            }
            else if (value.IsToolMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolMessage, typeof(global::G.ChatCompletionRequestToolMessage), options);
            }
            else if (value.IsFunctionMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionMessage, typeof(global::G.ChatCompletionRequestFunctionMessage), options);
            }
        }
    }
}