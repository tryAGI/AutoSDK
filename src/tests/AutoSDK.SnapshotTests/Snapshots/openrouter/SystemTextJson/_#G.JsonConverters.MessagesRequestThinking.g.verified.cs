//HintName: G.JsonConverters.MessagesRequestThinking.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestThinkingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestThinking>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestThinking Read(
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
            if (__jsonProps.Contains("budget_tokens")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.MessagesRequestThinking0? messagesRequestThinking0 = default;
            global::G.MessagesRequestThinking1? messagesRequestThinking1 = default;
            global::G.MessagesRequestThinking2? messagesRequestThinking2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        messagesRequestThinking0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestThinking0>(__rawJson, options);
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
                        messagesRequestThinking1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestThinking1>(__rawJson, options);
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
                        messagesRequestThinking2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestThinking2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesRequestThinking0 == null && messagesRequestThinking1 == null && messagesRequestThinking2 == null)
            {
                try
                {
                    messagesRequestThinking0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestThinking0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesRequestThinking1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestThinking1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesRequestThinking2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestThinking2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesRequestThinking(
                messagesRequestThinking0,

                messagesRequestThinking1,

                messagesRequestThinking2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestThinking value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessagesRequestThinking0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestThinking0, typeof(global::G.MessagesRequestThinking0), options);
            }
            else if (value.IsMessagesRequestThinking1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestThinking1, typeof(global::G.MessagesRequestThinking1), options);
            }
            else if (value.IsMessagesRequestThinking2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestThinking2, typeof(global::G.MessagesRequestThinking2), options);
            }
        }
    }
}