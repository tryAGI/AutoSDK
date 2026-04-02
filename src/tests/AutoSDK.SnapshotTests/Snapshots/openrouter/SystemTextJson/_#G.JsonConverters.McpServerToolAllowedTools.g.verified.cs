//HintName: G.JsonConverters.McpServerToolAllowedTools.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class McpServerToolAllowedToolsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.McpServerToolAllowedTools>
    {
        /// <inheritdoc />
        public override global::G.McpServerToolAllowedTools Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("read_only")) __score1++;
            if (__jsonProps.Contains("tool_names")) __score1++;
            var __score2 = 0;
            var __score3 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::System.Collections.Generic.IList<string>? mcpServerToolAllowedToolsVariant1 = default;
            global::G.McpServerToolAllowedTools1? mcpServerToolAllowedTools1 = default;
            object? mcpServerToolAllowedToolsVariant3 = default;
            object? mcpServerToolAllowedToolsVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        mcpServerToolAllowedToolsVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<string>>(__rawJson, options);
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
                        mcpServerToolAllowedTools1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpServerToolAllowedTools1>(__rawJson, options);
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
                        mcpServerToolAllowedToolsVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
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
                        mcpServerToolAllowedToolsVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (mcpServerToolAllowedToolsVariant1 == null && mcpServerToolAllowedTools1 == null && mcpServerToolAllowedToolsVariant3 == null && mcpServerToolAllowedToolsVariant4 == null)
            {
                try
                {
                    mcpServerToolAllowedToolsVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<string>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpServerToolAllowedTools1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpServerToolAllowedTools1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpServerToolAllowedToolsVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpServerToolAllowedToolsVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.McpServerToolAllowedTools(
                mcpServerToolAllowedToolsVariant1,

                mcpServerToolAllowedTools1,

                mcpServerToolAllowedToolsVariant3,

                mcpServerToolAllowedToolsVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.McpServerToolAllowedTools value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMcpServerToolAllowedToolsVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolAllowedToolsVariant1, typeof(global::System.Collections.Generic.IList<string>), options);
            }
            else if (value.IsMcpServerToolAllowedTools1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolAllowedTools1, typeof(global::G.McpServerToolAllowedTools1), options);
            }
            else if (value.IsMcpServerToolAllowedToolsVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolAllowedToolsVariant3, typeof(object), options);
            }
            else if (value.IsMcpServerToolAllowedToolsVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolAllowedToolsVariant4, typeof(object), options);
            }
        }
    }
}