//HintName: G.JsonConverters.MessagesRequestToolChoice.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestToolChoice>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestToolChoice Read(
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
            if (__jsonProps.Contains("disable_parallel_tool_use")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("disable_parallel_tool_use")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("disable_parallel_tool_use")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.MessagesRequestToolChoice0? messagesRequestToolChoice0 = default;
            global::G.MessagesRequestToolChoice1? messagesRequestToolChoice1 = default;
            global::G.MessagesRequestToolChoice2? messagesRequestToolChoice2 = default;
            global::G.MessagesRequestToolChoice3? messagesRequestToolChoice3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        messagesRequestToolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestToolChoice0>(__rawJson, options);
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
                        messagesRequestToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestToolChoice1>(__rawJson, options);
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
                        messagesRequestToolChoice2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestToolChoice2>(__rawJson, options);
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
                        messagesRequestToolChoice3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestToolChoice3>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesRequestToolChoice0 == null && messagesRequestToolChoice1 == null && messagesRequestToolChoice2 == null && messagesRequestToolChoice3 == null)
            {
                try
                {
                    messagesRequestToolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestToolChoice0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesRequestToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestToolChoice1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesRequestToolChoice2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestToolChoice2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesRequestToolChoice3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestToolChoice3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesRequestToolChoice(
                messagesRequestToolChoice0,

                messagesRequestToolChoice1,

                messagesRequestToolChoice2,

                messagesRequestToolChoice3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessagesRequestToolChoice0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestToolChoice0, typeof(global::G.MessagesRequestToolChoice0), options);
            }
            else if (value.IsMessagesRequestToolChoice1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestToolChoice1, typeof(global::G.MessagesRequestToolChoice1), options);
            }
            else if (value.IsMessagesRequestToolChoice2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestToolChoice2, typeof(global::G.MessagesRequestToolChoice2), options);
            }
            else if (value.IsMessagesRequestToolChoice3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestToolChoice3, typeof(global::G.MessagesRequestToolChoice3), options);
            }
        }
    }
}