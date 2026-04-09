//HintName: G.JsonConverters.MessagesRequestPluginsItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestPluginsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestPluginsItems>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestPluginsItems Read(
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
            if (__jsonProps.Contains("allowed_models")) __score0++;
            if (__jsonProps.Contains("enabled")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("enabled")) __score2++;
            if (__jsonProps.Contains("engine")) __score2++;
            if (__jsonProps.Contains("exclude_domains")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("include_domains")) __score2++;
            if (__jsonProps.Contains("max_results")) __score2++;
            if (__jsonProps.Contains("search_prompt")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("enabled")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("pdf")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("enabled")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("enabled")) __score5++;
            if (__jsonProps.Contains("engine")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.MessagesRequestPluginsItems0? messagesRequestPluginsItems0 = default;
            global::G.MessagesRequestPluginsItems1? messagesRequestPluginsItems1 = default;
            global::G.MessagesRequestPluginsItems2? messagesRequestPluginsItems2 = default;
            global::G.MessagesRequestPluginsItems3? messagesRequestPluginsItems3 = default;
            global::G.MessagesRequestPluginsItems4? messagesRequestPluginsItems4 = default;
            global::G.MessagesRequestPluginsItems5? messagesRequestPluginsItems5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems0).Name}");
                        messagesRequestPluginsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems1).Name}");
                        messagesRequestPluginsItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems2).Name}");
                        messagesRequestPluginsItems2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems3).Name}");
                        messagesRequestPluginsItems3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems4).Name}");
                        messagesRequestPluginsItems4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems5).Name}");
                        messagesRequestPluginsItems5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesRequestPluginsItems0 == null && messagesRequestPluginsItems1 == null && messagesRequestPluginsItems2 == null && messagesRequestPluginsItems3 == null && messagesRequestPluginsItems4 == null && messagesRequestPluginsItems5 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems0).Name}");
                    messagesRequestPluginsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems1).Name}");
                    messagesRequestPluginsItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems2).Name}");
                    messagesRequestPluginsItems2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems3).Name}");
                    messagesRequestPluginsItems3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems4).Name}");
                    messagesRequestPluginsItems4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems5).Name}");
                    messagesRequestPluginsItems5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesRequestPluginsItems(
                messagesRequestPluginsItems0,

                messagesRequestPluginsItems1,

                messagesRequestPluginsItems2,

                messagesRequestPluginsItems3,

                messagesRequestPluginsItems4,

                messagesRequestPluginsItems5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestPluginsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessagesRequestPluginsItems0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestPluginsItems0!, typeInfo);
            }
            else if (value.IsMessagesRequestPluginsItems1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestPluginsItems1!, typeInfo);
            }
            else if (value.IsMessagesRequestPluginsItems2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestPluginsItems2!, typeInfo);
            }
            else if (value.IsMessagesRequestPluginsItems3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestPluginsItems3!, typeInfo);
            }
            else if (value.IsMessagesRequestPluginsItems4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestPluginsItems4!, typeInfo);
            }
            else if (value.IsMessagesRequestPluginsItems5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessagesRequestPluginsItems5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessagesRequestPluginsItems5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessagesRequestPluginsItems5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestPluginsItems5!, typeInfo);
            }
        }
    }
}