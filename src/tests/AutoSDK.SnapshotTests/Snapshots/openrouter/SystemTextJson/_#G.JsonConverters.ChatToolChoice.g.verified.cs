//HintName: G.JsonConverters.ChatToolChoice.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatToolChoice>
    {
        /// <inheritdoc />
        public override global::G.ChatToolChoice Read(
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
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            if (__jsonProps.Contains("function")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.ChatToolChoice0? chatToolChoice0 = default;
            global::G.ChatToolChoice1? chatToolChoice1 = default;
            global::G.ChatToolChoice2? chatToolChoice2 = default;
            global::G.ChatNamedToolChoice? chatNamedToolChoice = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolChoice0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolChoice0).Name}");
                        chatToolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolChoice1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolChoice1).Name}");
                        chatToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolChoice2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolChoice2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolChoice2).Name}");
                        chatToolChoice2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatNamedToolChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatNamedToolChoice> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatNamedToolChoice).Name}");
                        chatNamedToolChoice = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatToolChoice0 == null && chatToolChoice1 == null && chatToolChoice2 == null && chatNamedToolChoice == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolChoice0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolChoice0).Name}");
                    chatToolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolChoice1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolChoice1).Name}");
                    chatToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolChoice2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolChoice2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolChoice2).Name}");
                    chatToolChoice2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatNamedToolChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatNamedToolChoice> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatNamedToolChoice).Name}");
                    chatNamedToolChoice = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatToolChoice(
                chatToolChoice0,

                chatToolChoice1,

                chatToolChoice2,

                chatNamedToolChoice
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChatToolChoice0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolChoice0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolChoice0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatToolChoice0!.Value, typeInfo);
            }
            else if (value.IsChatToolChoice1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolChoice1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolChoice1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatToolChoice1!.Value, typeInfo);
            }
            else if (value.IsChatToolChoice2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatToolChoice2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatToolChoice2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatToolChoice2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatToolChoice2!.Value, typeInfo);
            }
            else if (value.IsChatNamedToolChoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatNamedToolChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatNamedToolChoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatNamedToolChoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatNamedToolChoice!, typeInfo);
            }
        }
    }
}