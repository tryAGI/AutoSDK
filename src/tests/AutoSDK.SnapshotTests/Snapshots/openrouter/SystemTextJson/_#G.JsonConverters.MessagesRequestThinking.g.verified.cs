//HintName: G.JsonConverters.MessagesRequestThinking.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestThinkingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestThinking>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestThinking Read(
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
            if (__jsonProps.Contains("budget_tokens")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.MessagesRequestThinking0? messagesRequestThinking0 = default;
            global::G.MessagesRequestThinking1? messagesRequestThinking1 = default;
            global::G.MessagesRequestThinking2? messagesRequestThinking2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestThinking0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestThinking0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestThinking0).Name}");
                        messagesRequestThinking0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestThinking1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestThinking1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestThinking1).Name}");
                        messagesRequestThinking1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestThinking2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestThinking2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestThinking2).Name}");
                        messagesRequestThinking2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesRequestThinking0 == null && messagesRequestThinking1 == null && messagesRequestThinking2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestThinking0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestThinking0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestThinking0).Name}");
                    messagesRequestThinking0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestThinking1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestThinking1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestThinking1).Name}");
                    messagesRequestThinking1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestThinking2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestThinking2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestThinking2).Name}");
                    messagesRequestThinking2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesRequestThinking(
                messagesRequestThinking0,

                messagesRequestThinking1,

                messagesRequestThinking2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestThinking value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessagesRequestThinking0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestThinking0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestThinking0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestThinking0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestThinking0!, typeInfo);
            }
            else if (value.IsMessagesRequestThinking1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestThinking1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestThinking1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestThinking1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestThinking1!, typeInfo);
            }
            else if (value.IsMessagesRequestThinking2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestThinking2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestThinking2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestThinking2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestThinking2!, typeInfo);
            }
        }
    }
}