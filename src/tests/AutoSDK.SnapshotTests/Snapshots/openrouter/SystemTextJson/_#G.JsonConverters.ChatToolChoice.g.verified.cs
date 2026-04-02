//HintName: G.JsonConverters.ChatToolChoice.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatToolChoice>
    {
        /// <inheritdoc />
        public override global::G.ChatToolChoice Read(
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
            var __score3 = 0;
            if (__jsonProps.Contains("function")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.ChatToolChoice0? chatToolChoice0 = default;
            global::G.ChatToolChoice1? chatToolChoice1 = default;
            global::G.ChatToolChoice2? chatToolChoice2 = default;
            global::G.ChatNamedToolChoice? chatNamedToolChoice = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        chatToolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolChoice0>(__rawJson, options);
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
                        chatToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolChoice1>(__rawJson, options);
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
                        chatToolChoice2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolChoice2>(__rawJson, options);
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
                        chatNamedToolChoice = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatNamedToolChoice>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatToolChoice0 == null && chatToolChoice1 == null && chatToolChoice2 == null && chatNamedToolChoice == null)
            {
                try
                {
                    chatToolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolChoice0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolChoice1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatToolChoice2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatToolChoice2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatNamedToolChoice = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatNamedToolChoice>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatToolChoice(
                chatToolChoice0,

                chatToolChoice1,

                chatToolChoice2,

                chatNamedToolChoice
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChatToolChoice0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatToolChoice0, typeof(global::G.ChatToolChoice0), options);
            }
            else if (value.IsChatToolChoice1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatToolChoice1, typeof(global::G.ChatToolChoice1), options);
            }
            else if (value.IsChatToolChoice2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatToolChoice2, typeof(global::G.ChatToolChoice2), options);
            }
            else if (value.IsChatNamedToolChoice)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatNamedToolChoice, typeof(global::G.ChatNamedToolChoice), options);
            }
        }
    }
}