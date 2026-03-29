//HintName: G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestSystemOneOf1ItemsCitationsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestSystemOneOf1ItemsCitationsItems Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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

            global::G.MessagesRequestSystemOneOf1ItemsCitationsItems0? messagesRequestSystemOneOf1ItemsCitationsItems0 = default;
            global::G.MessagesRequestSystemOneOf1ItemsCitationsItems1? messagesRequestSystemOneOf1ItemsCitationsItems1 = default;
            global::G.MessagesRequestSystemOneOf1ItemsCitationsItems2? messagesRequestSystemOneOf1ItemsCitationsItems2 = default;
            global::G.MessagesRequestSystemOneOf1ItemsCitationsItems3? messagesRequestSystemOneOf1ItemsCitationsItems3 = default;
            global::G.MessagesRequestSystemOneOf1ItemsCitationsItems4? messagesRequestSystemOneOf1ItemsCitationsItems4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems0).Name}");
                        messagesRequestSystemOneOf1ItemsCitationsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems1).Name}");
                        messagesRequestSystemOneOf1ItemsCitationsItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems2).Name}");
                        messagesRequestSystemOneOf1ItemsCitationsItems2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems3).Name}");
                        messagesRequestSystemOneOf1ItemsCitationsItems3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems4).Name}");
                        messagesRequestSystemOneOf1ItemsCitationsItems4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesRequestSystemOneOf1ItemsCitationsItems0 == null && messagesRequestSystemOneOf1ItemsCitationsItems1 == null && messagesRequestSystemOneOf1ItemsCitationsItems2 == null && messagesRequestSystemOneOf1ItemsCitationsItems3 == null && messagesRequestSystemOneOf1ItemsCitationsItems4 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems0).Name}");
                    messagesRequestSystemOneOf1ItemsCitationsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems1).Name}");
                    messagesRequestSystemOneOf1ItemsCitationsItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems2).Name}");
                    messagesRequestSystemOneOf1ItemsCitationsItems2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems3).Name}");
                    messagesRequestSystemOneOf1ItemsCitationsItems3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems4).Name}");
                    messagesRequestSystemOneOf1ItemsCitationsItems4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesRequestSystemOneOf1ItemsCitationsItems(
                messagesRequestSystemOneOf1ItemsCitationsItems0,

                messagesRequestSystemOneOf1ItemsCitationsItems1,

                messagesRequestSystemOneOf1ItemsCitationsItems2,

                messagesRequestSystemOneOf1ItemsCitationsItems3,

                messagesRequestSystemOneOf1ItemsCitationsItems4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestSystemOneOf1ItemsCitationsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessagesRequestSystemOneOf1ItemsCitationsItems0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestSystemOneOf1ItemsCitationsItems0, typeInfo);
            }
            else if (value.IsMessagesRequestSystemOneOf1ItemsCitationsItems1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestSystemOneOf1ItemsCitationsItems1, typeInfo);
            }
            else if (value.IsMessagesRequestSystemOneOf1ItemsCitationsItems2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestSystemOneOf1ItemsCitationsItems2, typeInfo);
            }
            else if (value.IsMessagesRequestSystemOneOf1ItemsCitationsItems3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestSystemOneOf1ItemsCitationsItems3, typeInfo);
            }
            else if (value.IsMessagesRequestSystemOneOf1ItemsCitationsItems4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestSystemOneOf1ItemsCitationsItems4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestSystemOneOf1ItemsCitationsItems4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestSystemOneOf1ItemsCitationsItems4, typeInfo);
            }
        }
    }
}