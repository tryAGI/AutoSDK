//HintName: G.JsonConverters.ChatRequestResponseFormat.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatRequestResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatRequestResponseFormat>
    {
        /// <inheritdoc />
        public override global::G.ChatRequestResponseFormat Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("json_schema")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("grammar")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.ChatFormatTextConfig? chatFormatTextConfig = default;
            global::G.FormatJsonObjectConfig? formatJsonObjectConfig = default;
            global::G.ChatFormatJsonSchemaConfig? chatFormatJsonSchemaConfig = default;
            global::G.ChatFormatGrammarConfig? chatFormatGrammarConfig = default;
            global::G.ChatFormatPythonConfig? chatFormatPythonConfig = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatTextConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatTextConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatTextConfig).Name}");
                        chatFormatTextConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FormatJsonObjectConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FormatJsonObjectConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FormatJsonObjectConfig).Name}");
                        formatJsonObjectConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatJsonSchemaConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatJsonSchemaConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatJsonSchemaConfig).Name}");
                        chatFormatJsonSchemaConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatGrammarConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatGrammarConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatGrammarConfig).Name}");
                        chatFormatGrammarConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatPythonConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatPythonConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatPythonConfig).Name}");
                        chatFormatPythonConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatFormatTextConfig == null && formatJsonObjectConfig == null && chatFormatJsonSchemaConfig == null && chatFormatGrammarConfig == null && chatFormatPythonConfig == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatTextConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatTextConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatTextConfig).Name}");
                    chatFormatTextConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FormatJsonObjectConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FormatJsonObjectConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FormatJsonObjectConfig).Name}");
                    formatJsonObjectConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatJsonSchemaConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatJsonSchemaConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatJsonSchemaConfig).Name}");
                    chatFormatJsonSchemaConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatGrammarConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatGrammarConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatGrammarConfig).Name}");
                    chatFormatGrammarConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatPythonConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatPythonConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatPythonConfig).Name}");
                    chatFormatPythonConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatRequestResponseFormat(
                chatFormatTextConfig,

                formatJsonObjectConfig,

                chatFormatJsonSchemaConfig,

                chatFormatGrammarConfig,

                chatFormatPythonConfig
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatRequestResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChatFormatTextConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatTextConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatTextConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatTextConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatTextConfig!, typeInfo);
            }
            else if (value.IsFormatJsonObjectConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FormatJsonObjectConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FormatJsonObjectConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FormatJsonObjectConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FormatJsonObjectConfig!, typeInfo);
            }
            else if (value.IsChatFormatJsonSchemaConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatJsonSchemaConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatJsonSchemaConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatJsonSchemaConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatJsonSchemaConfig!, typeInfo);
            }
            else if (value.IsChatFormatGrammarConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatGrammarConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatGrammarConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatGrammarConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatGrammarConfig!, typeInfo);
            }
            else if (value.IsChatFormatPythonConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatFormatPythonConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatFormatPythonConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatFormatPythonConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatPythonConfig!, typeInfo);
            }
        }
    }
}