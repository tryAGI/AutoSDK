//HintName: G.JsonConverters.MessagesRequestContextManagementEditsItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestContextManagementEditsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestContextManagementEditsItems>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestContextManagementEditsItems Read(
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
            if (__jsonProps.Contains("clear_at_least")) __score0++;
            if (__jsonProps.Contains("clear_tool_inputs")) __score0++;
            if (__jsonProps.Contains("exclude_tools")) __score0++;
            if (__jsonProps.Contains("keep")) __score0++;
            if (__jsonProps.Contains("trigger")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("keep")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("instructions")) __score2++;
            if (__jsonProps.Contains("pause_after_compaction")) __score2++;
            if (__jsonProps.Contains("trigger")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.MessagesRequestContextManagementEditsItems0? messagesRequestContextManagementEditsItems0 = default;
            global::G.MessagesRequestContextManagementEditsItems1? messagesRequestContextManagementEditsItems1 = default;
            global::G.MessagesRequestContextManagementEditsItems2? messagesRequestContextManagementEditsItems2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        messagesRequestContextManagementEditsItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItems0>(__rawJson, options);
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
                        messagesRequestContextManagementEditsItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItems1>(__rawJson, options);
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
                        messagesRequestContextManagementEditsItems2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItems2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesRequestContextManagementEditsItems0 == null && messagesRequestContextManagementEditsItems1 == null && messagesRequestContextManagementEditsItems2 == null)
            {
                try
                {
                    messagesRequestContextManagementEditsItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItems0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesRequestContextManagementEditsItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItems1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesRequestContextManagementEditsItems2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItems2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesRequestContextManagementEditsItems(
                messagesRequestContextManagementEditsItems0,

                messagesRequestContextManagementEditsItems1,

                messagesRequestContextManagementEditsItems2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestContextManagementEditsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessagesRequestContextManagementEditsItems0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestContextManagementEditsItems0, typeof(global::G.MessagesRequestContextManagementEditsItems0), options);
            }
            else if (value.IsMessagesRequestContextManagementEditsItems1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestContextManagementEditsItems1, typeof(global::G.MessagesRequestContextManagementEditsItems1), options);
            }
            else if (value.IsMessagesRequestContextManagementEditsItems2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestContextManagementEditsItems2, typeof(global::G.MessagesRequestContextManagementEditsItems2), options);
            }
        }
    }
}