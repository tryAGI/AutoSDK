//HintName: G.JsonConverters.ChatToolMessageContent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatToolMessageContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatToolMessageContent>
    {
        /// <inheritdoc />
        public override global::G.ChatToolMessageContent Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            string? chatToolMessageContentVariant1 = default;
            global::System.Collections.Generic.IList<global::G.ChatContentItems>? chatToolMessageContent1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        chatToolMessageContentVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        chatToolMessageContent1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ChatContentItems>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatToolMessageContentVariant1 == null && chatToolMessageContent1 == null)
            {
                try
                {

                    chatToolMessageContentVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    chatToolMessageContent1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ChatContentItems>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatToolMessageContent(
                chatToolMessageContentVariant1,

                chatToolMessageContent1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatToolMessageContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChatToolMessageContentVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatToolMessageContentVariant1, typeof(string), options);
            }
            else if (value.IsChatToolMessageContent1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatToolMessageContent1, typeof(global::System.Collections.Generic.IList<global::G.ChatContentItems>), options);
            }
        }
    }
}