//HintName: G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems>
    {
        /// <inheritdoc />
        public override global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems Read(
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
            if (__jsonProps.Contains("cited_text")) __score0++;
            if (__jsonProps.Contains("document_index")) __score0++;
            if (__jsonProps.Contains("document_title")) __score0++;
            if (__jsonProps.Contains("end_char_index")) __score0++;
            if (__jsonProps.Contains("start_char_index")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("cited_text")) __score1++;
            if (__jsonProps.Contains("document_index")) __score1++;
            if (__jsonProps.Contains("document_title")) __score1++;
            if (__jsonProps.Contains("end_page_number")) __score1++;
            if (__jsonProps.Contains("start_page_number")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("cited_text")) __score2++;
            if (__jsonProps.Contains("document_index")) __score2++;
            if (__jsonProps.Contains("document_title")) __score2++;
            if (__jsonProps.Contains("end_block_index")) __score2++;
            if (__jsonProps.Contains("start_block_index")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("cited_text")) __score3++;
            if (__jsonProps.Contains("encrypted_index")) __score3++;
            if (__jsonProps.Contains("title")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("url")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("cited_text")) __score4++;
            if (__jsonProps.Contains("end_block_index")) __score4++;
            if (__jsonProps.Contains("search_result_index")) __score4++;
            if (__jsonProps.Contains("source")) __score4++;
            if (__jsonProps.Contains("start_block_index")) __score4++;
            if (__jsonProps.Contains("title")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0>(__rawJson, options);
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
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1>(__rawJson, options);
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
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2>(__rawJson, options);
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
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0 == null && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1 == null && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2 == null && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3 == null && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4 == null)
            {
                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems(
                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0,

                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1,

                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2,

                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3,

                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems0), options);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems1), options);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems2), options);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems3), options);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItems4), options);
            }
        }
    }
}