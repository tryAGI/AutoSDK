//HintName: G.JsonConverters.MessagesMessageParamContentOneOf1Items.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesMessageParamContentOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesMessageParamContentOneOf1Items>
    {
        /// <inheritdoc />
        public override global::G.MessagesMessageParamContentOneOf1Items Read(
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
            if (__jsonProps.Contains("cache_control")) __score0++;
            if (__jsonProps.Contains("citations")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("cache_control")) __score1++;
            if (__jsonProps.Contains("source")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("cache_control")) __score2++;
            if (__jsonProps.Contains("citations")) __score2++;
            if (__jsonProps.Contains("context")) __score2++;
            if (__jsonProps.Contains("source")) __score2++;
            if (__jsonProps.Contains("title")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("cache_control")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("input")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("cache_control")) __score4++;
            if (__jsonProps.Contains("content")) __score4++;
            if (__jsonProps.Contains("is_error")) __score4++;
            if (__jsonProps.Contains("tool_use_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("signature")) __score5++;
            if (__jsonProps.Contains("thinking")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("data")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("cache_control")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("input")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("cache_control")) __score8++;
            if (__jsonProps.Contains("content")) __score8++;
            if (__jsonProps.Contains("tool_use_id")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("cache_control")) __score9++;
            if (__jsonProps.Contains("citations")) __score9++;
            if (__jsonProps.Contains("content")) __score9++;
            if (__jsonProps.Contains("source")) __score9++;
            if (__jsonProps.Contains("title")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }

            global::G.MessagesMessageParamContentOneOf1Items0? messagesMessageParamContentOneOf1Items0 = default;
            global::G.MessagesMessageParamContentOneOf1Items1? messagesMessageParamContentOneOf1Items1 = default;
            global::G.MessagesMessageParamContentOneOf1Items2? messagesMessageParamContentOneOf1Items2 = default;
            global::G.MessagesMessageParamContentOneOf1Items3? messagesMessageParamContentOneOf1Items3 = default;
            global::G.MessagesMessageParamContentOneOf1Items4? messagesMessageParamContentOneOf1Items4 = default;
            global::G.MessagesMessageParamContentOneOf1Items5? messagesMessageParamContentOneOf1Items5 = default;
            global::G.MessagesMessageParamContentOneOf1Items6? messagesMessageParamContentOneOf1Items6 = default;
            global::G.MessagesMessageParamContentOneOf1Items7? messagesMessageParamContentOneOf1Items7 = default;
            global::G.MessagesMessageParamContentOneOf1Items8? messagesMessageParamContentOneOf1Items8 = default;
            global::G.MessagesMessageParamContentOneOf1Items9? messagesMessageParamContentOneOf1Items9 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items0).Name}");
                        messagesMessageParamContentOneOf1Items0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items1).Name}");
                        messagesMessageParamContentOneOf1Items1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items2).Name}");
                        messagesMessageParamContentOneOf1Items2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items3).Name}");
                        messagesMessageParamContentOneOf1Items3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items4).Name}");
                        messagesMessageParamContentOneOf1Items4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items5).Name}");
                        messagesMessageParamContentOneOf1Items5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items6).Name}");
                        messagesMessageParamContentOneOf1Items6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items7).Name}");
                        messagesMessageParamContentOneOf1Items7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items8).Name}");
                        messagesMessageParamContentOneOf1Items8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items9).Name}");
                        messagesMessageParamContentOneOf1Items9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesMessageParamContentOneOf1Items0 == null && messagesMessageParamContentOneOf1Items1 == null && messagesMessageParamContentOneOf1Items2 == null && messagesMessageParamContentOneOf1Items3 == null && messagesMessageParamContentOneOf1Items4 == null && messagesMessageParamContentOneOf1Items5 == null && messagesMessageParamContentOneOf1Items6 == null && messagesMessageParamContentOneOf1Items7 == null && messagesMessageParamContentOneOf1Items8 == null && messagesMessageParamContentOneOf1Items9 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items0).Name}");
                    messagesMessageParamContentOneOf1Items0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items1).Name}");
                    messagesMessageParamContentOneOf1Items1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items2).Name}");
                    messagesMessageParamContentOneOf1Items2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items3).Name}");
                    messagesMessageParamContentOneOf1Items3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items4).Name}");
                    messagesMessageParamContentOneOf1Items4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items5).Name}");
                    messagesMessageParamContentOneOf1Items5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items6).Name}");
                    messagesMessageParamContentOneOf1Items6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items7).Name}");
                    messagesMessageParamContentOneOf1Items7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items8).Name}");
                    messagesMessageParamContentOneOf1Items8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items9).Name}");
                    messagesMessageParamContentOneOf1Items9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesMessageParamContentOneOf1Items(
                messagesMessageParamContentOneOf1Items0,

                messagesMessageParamContentOneOf1Items1,

                messagesMessageParamContentOneOf1Items2,

                messagesMessageParamContentOneOf1Items3,

                messagesMessageParamContentOneOf1Items4,

                messagesMessageParamContentOneOf1Items5,

                messagesMessageParamContentOneOf1Items6,

                messagesMessageParamContentOneOf1Items7,

                messagesMessageParamContentOneOf1Items8,

                messagesMessageParamContentOneOf1Items9
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesMessageParamContentOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessagesMessageParamContentOneOf1Items0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1Items0, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1Items1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1Items1, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1Items2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1Items2, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1Items3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1Items3, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1Items4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1Items4, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1Items5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1Items5, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1Items6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1Items6, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1Items7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1Items7, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1Items8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1Items8, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1Items9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1Items9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1Items9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1Items9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1Items9, typeInfo);
            }
        }
    }
}