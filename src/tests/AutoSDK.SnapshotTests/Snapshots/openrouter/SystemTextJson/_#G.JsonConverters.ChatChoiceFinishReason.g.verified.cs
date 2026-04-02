//HintName: G.JsonConverters.ChatChoiceFinishReason.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatChoiceFinishReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatChoiceFinishReason>
    {
        /// <inheritdoc />
        public override global::G.ChatChoiceFinishReason Read(
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

            global::G.ChatFinishReasonEnum? chatFinishReasonEnum = default;
            object? chatChoiceFinishReasonVariant2 = default;
            object? chatChoiceFinishReasonVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        chatFinishReasonEnum = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFinishReasonEnum>(__rawJson, options);
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

                        chatChoiceFinishReasonVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
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

                        chatChoiceFinishReasonVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatFinishReasonEnum == null && chatChoiceFinishReasonVariant2 == null && chatChoiceFinishReasonVariant3 == null)
            {
                try
                {

                    chatFinishReasonEnum = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFinishReasonEnum>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    chatChoiceFinishReasonVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    chatChoiceFinishReasonVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatChoiceFinishReason(
                chatFinishReasonEnum,

                chatChoiceFinishReasonVariant2,

                chatChoiceFinishReasonVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatChoiceFinishReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChatFinishReasonEnum)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFinishReasonEnum, typeof(global::G.ChatFinishReasonEnum), options);
            }
            else if (value.IsChatChoiceFinishReasonVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatChoiceFinishReasonVariant2, typeof(object), options);
            }
            else if (value.IsChatChoiceFinishReasonVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatChoiceFinishReasonVariant3, typeof(object), options);
            }
        }
    }
}