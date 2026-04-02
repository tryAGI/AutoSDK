//HintName: G.JsonConverters.ChatAssistantMessageContent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatAssistantMessageContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatAssistantMessageContent>
    {
        /// <inheritdoc />
        public override global::G.ChatAssistantMessageContent Read(
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
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            string? chatAssistantMessageContentVariant1 = default;
            global::System.Collections.Generic.IList<global::G.ChatContentItems>? chatAssistantMessageContent1 = default;
            object? chatAssistantMessageContentVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        chatAssistantMessageContentVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        chatAssistantMessageContent1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ChatContentItems>>(__rawJson, options);
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

                        chatAssistantMessageContentVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatAssistantMessageContentVariant1 == null && chatAssistantMessageContent1 == null && chatAssistantMessageContentVariant3 == null)
            {
                try
                {

                    chatAssistantMessageContentVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    chatAssistantMessageContent1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ChatContentItems>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    chatAssistantMessageContentVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatAssistantMessageContent(
                chatAssistantMessageContentVariant1,

                chatAssistantMessageContent1,

                chatAssistantMessageContentVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatAssistantMessageContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChatAssistantMessageContentVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatAssistantMessageContentVariant1, typeof(string), options);
            }
            else if (value.IsChatAssistantMessageContent1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatAssistantMessageContent1, typeof(global::System.Collections.Generic.IList<global::G.ChatContentItems>), options);
            }
            else if (value.IsChatAssistantMessageContentVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatAssistantMessageContentVariant3, typeof(object), options);
            }
        }
    }
}