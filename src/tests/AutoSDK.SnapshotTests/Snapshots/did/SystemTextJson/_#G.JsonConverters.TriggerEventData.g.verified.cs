//HintName: G.JsonConverters.TriggerEventData.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TriggerEventDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TriggerEventData>
    {
        /// <inheritdoc />
        public override global::G.TriggerEventData Read(
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
            if (__jsonProps.Contains("agent_id")) __score0++;
            if (__jsonProps.Contains("chat_history")) __score0++;
            if (__jsonProps.Contains("chat_id")) __score0++;
            if (__jsonProps.Contains("event_type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("agent_id")) __score1++;
            if (__jsonProps.Contains("chat_id")) __score1++;
            if (__jsonProps.Contains("event_type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ChatEndEventData? chatEnd = default;
            global::G.TriggerEventDataVariant2? triggerEventDataVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        chatEnd = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatEndEventData>(__rawJson, options);
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
                        triggerEventDataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TriggerEventDataVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatEnd == null && triggerEventDataVariant2 == null)
            {
                try
                {
                    chatEnd = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatEndEventData>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    triggerEventDataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TriggerEventDataVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TriggerEventData(
                chatEnd,

                triggerEventDataVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TriggerEventData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChatEnd)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatEnd, typeof(global::G.ChatEndEventData), options);
            }
            else if (value.IsTriggerEventDataVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TriggerEventDataVariant2, typeof(global::G.TriggerEventDataVariant2), options);
            }
        }
    }
}