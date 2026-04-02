//HintName: G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0Trigger.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestContextManagementEditsItemsOneOf0TriggerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger Read(
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
            if (__jsonProps.Contains("value")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0? messagesRequestContextManagementEditsItemsOneOf0Trigger0 = default;
            global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1? messagesRequestContextManagementEditsItemsOneOf0Trigger1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        messagesRequestContextManagementEditsItemsOneOf0Trigger0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0>(__rawJson, options);
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
                        messagesRequestContextManagementEditsItemsOneOf0Trigger1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesRequestContextManagementEditsItemsOneOf0Trigger0 == null && messagesRequestContextManagementEditsItemsOneOf0Trigger1 == null)
            {
                try
                {
                    messagesRequestContextManagementEditsItemsOneOf0Trigger0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesRequestContextManagementEditsItemsOneOf0Trigger1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger(
                messagesRequestContextManagementEditsItemsOneOf0Trigger0,

                messagesRequestContextManagementEditsItemsOneOf0Trigger1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessagesRequestContextManagementEditsItemsOneOf0Trigger0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestContextManagementEditsItemsOneOf0Trigger0, typeof(global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0), options);
            }
            else if (value.IsMessagesRequestContextManagementEditsItemsOneOf0Trigger1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestContextManagementEditsItemsOneOf0Trigger1, typeof(global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1), options);
            }
        }
    }
}