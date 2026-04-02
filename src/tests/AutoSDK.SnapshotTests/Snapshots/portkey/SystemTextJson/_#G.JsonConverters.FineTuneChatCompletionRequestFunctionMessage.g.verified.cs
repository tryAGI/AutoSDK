//HintName: G.JsonConverters.FineTuneChatCompletionRequestFunctionMessage.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FineTuneChatCompletionRequestFunctionMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FineTuneChatCompletionRequestFunctionMessage>
    {
        /// <inheritdoc />
        public override global::G.FineTuneChatCompletionRequestFunctionMessage Read(
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
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            object? functionMessage1 = default;
            global::G.ChatCompletionRequestFunctionMessage? functionMessage2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        functionMessage1 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
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
                        functionMessage2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestFunctionMessage>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (functionMessage1 == null && functionMessage2 == null)
            {
                try
                {
                    functionMessage1 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionMessage2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestFunctionMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FineTuneChatCompletionRequestFunctionMessage(
                functionMessage1,

                functionMessage2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FineTuneChatCompletionRequestFunctionMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFunctionMessage1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionMessage1, typeof(object), options);
            }
            else if (value.IsFunctionMessage2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionMessage2, typeof(global::G.ChatCompletionRequestFunctionMessage), options);
            }
        }
    }
}