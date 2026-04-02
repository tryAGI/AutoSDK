//HintName: G.JsonConverters.ChatMessages.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatMessagesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatMessages>
    {
        /// <inheritdoc />
        public override global::G.ChatMessages Read(
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
            if (__jsonProps.Contains("images")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("reasoning")) __score3++;
            if (__jsonProps.Contains("reasoning_details")) __score3++;
            if (__jsonProps.Contains("refusal")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            if (__jsonProps.Contains("tool_calls")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("content")) __score4++;
            if (__jsonProps.Contains("role")) __score4++;
            if (__jsonProps.Contains("tool_call_id")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.ChatSystemMessage? chatSystemMessage = default;
            global::G.ChatUserMessage? chatUserMessage = default;
            global::G.ChatDeveloperMessage? chatDeveloperMessage = default;
            global::G.ChatAssistantMessage? chatAssistantMessage = default;
            global::G.ChatToolMessage? chatToolMessage = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        chatSystemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatSystemMessage>(__rawJson, options);
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
                        chatUserMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatUserMessage>(__rawJson, options);
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
                        chatDeveloperMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatDeveloperMessage>(__rawJson, options);
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
                        chatAssistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatAssistantMessage>(__rawJson, options);
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
                        chatToolMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolMessage>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatSystemMessage == null && chatUserMessage == null && chatDeveloperMessage == null && chatAssistantMessage == null && chatToolMessage == null)
            {
                try
                {
                    chatSystemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatSystemMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatUserMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatUserMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatDeveloperMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatDeveloperMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatAssistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatAssistantMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatToolMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatMessages(
                chatSystemMessage,

                chatUserMessage,

                chatDeveloperMessage,

                chatAssistantMessage,

                chatToolMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatMessages value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChatSystemMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatSystemMessage, typeof(global::G.ChatSystemMessage), options);
            }
            else if (value.IsChatUserMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatUserMessage, typeof(global::G.ChatUserMessage), options);
            }
            else if (value.IsChatDeveloperMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatDeveloperMessage, typeof(global::G.ChatDeveloperMessage), options);
            }
            else if (value.IsChatAssistantMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatAssistantMessage, typeof(global::G.ChatAssistantMessage), options);
            }
            else if (value.IsChatToolMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatToolMessage, typeof(global::G.ChatToolMessage), options);
            }
        }
    }
}