//HintName: G.JsonConverters.ChatCompletionMessageContentBlock.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionMessageContentBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionMessageContentBlock>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionMessageContentBlock Read(
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
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("thinking")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.ChatCompletionRequestMessageContentPartText? textContentPart = default;
            global::G.ChatCompletionMessageContentPartThinking? thinkingContentPart = default;
            global::G.ChatCompletionMessageContentPartRedactedThinking? redactedThinkingContentPart = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        textContentPart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestMessageContentPartText>(__rawJson, options);
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
                        thinkingContentPart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageContentPartThinking>(__rawJson, options);
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
                        redactedThinkingContentPart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageContentPartRedactedThinking>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textContentPart == null && thinkingContentPart == null && redactedThinkingContentPart == null)
            {
                try
                {
                    textContentPart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionRequestMessageContentPartText>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    thinkingContentPart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageContentPartThinking>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    redactedThinkingContentPart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageContentPartRedactedThinking>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatCompletionMessageContentBlock(
                textContentPart,

                thinkingContentPart,

                redactedThinkingContentPart
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionMessageContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextContentPart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextContentPart, typeof(global::G.ChatCompletionRequestMessageContentPartText), options);
            }
            else if (value.IsThinkingContentPart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingContentPart, typeof(global::G.ChatCompletionMessageContentPartThinking), options);
            }
            else if (value.IsRedactedThinkingContentPart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinkingContentPart, typeof(global::G.ChatCompletionMessageContentPartRedactedThinking), options);
            }
        }
    }
}