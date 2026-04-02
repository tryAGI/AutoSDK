//HintName: G.JsonConverters.FineTuneChatCompletionRequestAssistantMessage.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FineTuneChatCompletionRequestAssistantMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FineTuneChatCompletionRequestAssistantMessage>
    {
        /// <inheritdoc />
        public override global::G.FineTuneChatCompletionRequestAssistantMessage Read(
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
            if (__jsonProps.Contains("weight")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("audio")) __score1++;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("function_call")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("refusal")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("tool_calls")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.FineTuneChatCompletionRequestAssistantMessageAssistantMessage? assistantMessage1 = default;
            global::G.ChatCompletionRequestAssistantMessage? assistantMessage2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        assistantMessage1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FineTuneChatCompletionRequestAssistantMessageAssistantMessage>(__rawJson, options);
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
                        assistantMessage2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestAssistantMessage>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (assistantMessage1 == null && assistantMessage2 == null)
            {
                try
                {
                    assistantMessage1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FineTuneChatCompletionRequestAssistantMessageAssistantMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    assistantMessage2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestAssistantMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FineTuneChatCompletionRequestAssistantMessage(
                assistantMessage1,

                assistantMessage2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FineTuneChatCompletionRequestAssistantMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAssistantMessage1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage1, typeof(global::G.FineTuneChatCompletionRequestAssistantMessageAssistantMessage), options);
            }
            else if (value.IsAssistantMessage2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage2, typeof(global::G.ChatCompletionRequestAssistantMessage), options);
            }
        }
    }
}