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
                        chatFormatTextConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFormatTextConfig>(__rawJson, options);
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
                        formatJsonObjectConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FormatJsonObjectConfig>(__rawJson, options);
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
                        chatFormatJsonSchemaConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFormatJsonSchemaConfig>(__rawJson, options);
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
                        chatFormatGrammarConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFormatGrammarConfig>(__rawJson, options);
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
                        chatFormatPythonConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFormatPythonConfig>(__rawJson, options);
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
                    chatFormatTextConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFormatTextConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    formatJsonObjectConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FormatJsonObjectConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatFormatJsonSchemaConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFormatJsonSchemaConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatFormatGrammarConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFormatGrammarConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatFormatPythonConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFormatPythonConfig>(__rawJson, options);
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

            if (value.IsChatFormatTextConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatTextConfig, typeof(global::G.ChatFormatTextConfig), options);
            }
            else if (value.IsFormatJsonObjectConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FormatJsonObjectConfig, typeof(global::G.FormatJsonObjectConfig), options);
            }
            else if (value.IsChatFormatJsonSchemaConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatJsonSchemaConfig, typeof(global::G.ChatFormatJsonSchemaConfig), options);
            }
            else if (value.IsChatFormatGrammarConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatGrammarConfig, typeof(global::G.ChatFormatGrammarConfig), options);
            }
            else if (value.IsChatFormatPythonConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatPythonConfig, typeof(global::G.ChatFormatPythonConfig), options);
            }
        }
    }
}