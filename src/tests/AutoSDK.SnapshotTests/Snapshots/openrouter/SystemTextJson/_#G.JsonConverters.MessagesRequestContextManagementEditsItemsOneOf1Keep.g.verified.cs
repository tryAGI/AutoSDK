//HintName: G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1Keep.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestContextManagementEditsItemsOneOf1KeepJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0? messagesRequestContextManagementEditsItemsOneOf1Keep0 = default;
            global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1? messagesRequestContextManagementEditsItemsOneOf1Keep1 = default;
            global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2? messagesRequestContextManagementEditsItemsOneOf1Keep2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        messagesRequestContextManagementEditsItemsOneOf1Keep0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0>(__rawJson, options);
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
                        messagesRequestContextManagementEditsItemsOneOf1Keep1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1>(__rawJson, options);
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
                        messagesRequestContextManagementEditsItemsOneOf1Keep2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesRequestContextManagementEditsItemsOneOf1Keep0 == null && messagesRequestContextManagementEditsItemsOneOf1Keep1 == null && messagesRequestContextManagementEditsItemsOneOf1Keep2 == null)
            {
                try
                {
                    messagesRequestContextManagementEditsItemsOneOf1Keep0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesRequestContextManagementEditsItemsOneOf1Keep1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesRequestContextManagementEditsItemsOneOf1Keep2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep(
                messagesRequestContextManagementEditsItemsOneOf1Keep0,

                messagesRequestContextManagementEditsItemsOneOf1Keep1,

                messagesRequestContextManagementEditsItemsOneOf1Keep2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessagesRequestContextManagementEditsItemsOneOf1Keep0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestContextManagementEditsItemsOneOf1Keep0, typeof(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0), options);
            }
            else if (value.IsMessagesRequestContextManagementEditsItemsOneOf1Keep1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestContextManagementEditsItemsOneOf1Keep1, typeof(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1), options);
            }
            else if (value.IsMessagesRequestContextManagementEditsItemsOneOf1Keep2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestContextManagementEditsItemsOneOf1Keep2, typeof(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2), options);
            }
        }
    }
}