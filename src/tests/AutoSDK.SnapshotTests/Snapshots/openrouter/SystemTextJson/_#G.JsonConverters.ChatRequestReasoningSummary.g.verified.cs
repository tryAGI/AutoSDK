//HintName: G.JsonConverters.ChatRequestReasoningSummary.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatRequestReasoningSummaryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatRequestReasoningSummary>
    {
        /// <inheritdoc />
        public override global::G.ChatRequestReasoningSummary Read(
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

            global::G.ChatReasoningSummaryVerbosityEnum? chatReasoningSummaryVerbosityEnum = default;
            object? chatRequestReasoningSummaryVariant2 = default;
            object? chatRequestReasoningSummaryVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        chatReasoningSummaryVerbosityEnum = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatReasoningSummaryVerbosityEnum>(__rawJson, options);
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

                        chatRequestReasoningSummaryVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
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

                        chatRequestReasoningSummaryVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatReasoningSummaryVerbosityEnum == null && chatRequestReasoningSummaryVariant2 == null && chatRequestReasoningSummaryVariant3 == null)
            {
                try
                {

                    chatReasoningSummaryVerbosityEnum = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatReasoningSummaryVerbosityEnum>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    chatRequestReasoningSummaryVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    chatRequestReasoningSummaryVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatRequestReasoningSummary(
                chatReasoningSummaryVerbosityEnum,

                chatRequestReasoningSummaryVariant2,

                chatRequestReasoningSummaryVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatRequestReasoningSummary value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChatReasoningSummaryVerbosityEnum)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatReasoningSummaryVerbosityEnum, typeof(global::G.ChatReasoningSummaryVerbosityEnum), options);
            }
            else if (value.IsChatRequestReasoningSummaryVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestReasoningSummaryVariant2, typeof(object), options);
            }
            else if (value.IsChatRequestReasoningSummaryVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestReasoningSummaryVariant3, typeof(object), options);
            }
        }
    }
}