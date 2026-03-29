//HintName: G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>
    {
        /// <inheritdoc />
        public override global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items Read(
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
            if (__jsonProps.Contains("tool_name")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("cache_control")) __score3++;
            if (__jsonProps.Contains("citations")) __score3++;
            if (__jsonProps.Contains("content")) __score3++;
            if (__jsonProps.Contains("source")) __score3++;
            if (__jsonProps.Contains("title")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("cache_control")) __score4++;
            if (__jsonProps.Contains("citations")) __score4++;
            if (__jsonProps.Contains("context")) __score4++;
            if (__jsonProps.Contains("source")) __score4++;
            if (__jsonProps.Contains("title")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0).Name}");
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1).Name}");
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2).Name}");
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3).Name}");
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4).Name}");
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0 == null && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1 == null && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 == null && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3 == null && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0).Name}");
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1).Name}");
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2).Name}");
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3).Name}");
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4).Name}");
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(
                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0,

                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1,

                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2,

                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3,

                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items0, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items1, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items3, typeInfo);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items4, typeInfo);
            }
        }
    }
}