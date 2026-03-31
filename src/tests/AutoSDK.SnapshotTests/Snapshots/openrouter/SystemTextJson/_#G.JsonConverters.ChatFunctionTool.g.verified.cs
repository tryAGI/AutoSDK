//HintName: G.JsonConverters.ChatFunctionTool.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatFunctionToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatFunctionTool>
    {
        /// <inheritdoc />
        public override global::G.ChatFunctionTool Read(
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
            if (__jsonProps.Contains("function")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("parameters")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("parameters")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("allowed_domains")) __score3++;
            if (__jsonProps.Contains("engine")) __score3++;
            if (__jsonProps.Contains("excluded_domains")) __score3++;
            if (__jsonProps.Contains("max_results")) __score3++;
            if (__jsonProps.Contains("max_total_results")) __score3++;
            if (__jsonProps.Contains("parameters")) __score3++;
            if (__jsonProps.Contains("search_context_size")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("user_location")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.ChatFunctionTool0? chatFunctionTool0 = default;
            global::G.DatetimeServerTool? datetimeServerTool = default;
            global::G.ChatWebSearchServerTool? chatWebSearchServerTool = default;
            global::G.ChatWebSearchShorthand? chatWebSearchShorthand = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFunctionTool0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFunctionTool0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFunctionTool0).Name}");
                        chatFunctionTool0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DatetimeServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DatetimeServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DatetimeServerTool).Name}");
                        datetimeServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatWebSearchServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatWebSearchServerTool).Name}");
                        chatWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatWebSearchShorthand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatWebSearchShorthand> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatWebSearchShorthand).Name}");
                        chatWebSearchShorthand = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatFunctionTool0 == null && datetimeServerTool == null && chatWebSearchServerTool == null && chatWebSearchShorthand == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFunctionTool0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFunctionTool0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFunctionTool0).Name}");
                    chatFunctionTool0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DatetimeServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DatetimeServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DatetimeServerTool).Name}");
                    datetimeServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatWebSearchServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatWebSearchServerTool).Name}");
                    chatWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatWebSearchShorthand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatWebSearchShorthand> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatWebSearchShorthand).Name}");
                    chatWebSearchShorthand = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatFunctionTool(
                chatFunctionTool0,

                datetimeServerTool,

                chatWebSearchServerTool,

                chatWebSearchShorthand
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatFunctionTool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChatFunctionTool0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFunctionTool0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFunctionTool0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFunctionTool0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFunctionTool0!, typeInfo);
            }
            else if (value.IsDatetimeServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DatetimeServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DatetimeServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DatetimeServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DatetimeServerTool!, typeInfo);
            }
            else if (value.IsChatWebSearchServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatWebSearchServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatWebSearchServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatWebSearchServerTool!, typeInfo);
            }
            else if (value.IsChatWebSearchShorthand)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatWebSearchShorthand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatWebSearchShorthand?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatWebSearchShorthand).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatWebSearchShorthand!, typeInfo);
            }
        }
    }
}