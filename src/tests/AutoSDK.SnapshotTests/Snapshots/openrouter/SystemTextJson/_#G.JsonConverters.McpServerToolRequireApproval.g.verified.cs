//HintName: G.JsonConverters.McpServerToolRequireApproval.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class McpServerToolRequireApprovalJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.McpServerToolRequireApproval>
    {
        /// <inheritdoc />
        public override global::G.McpServerToolRequireApproval Read(
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
            if (__jsonProps.Contains("always")) __score0++;
            if (__jsonProps.Contains("never")) __score0++;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.McpServerToolRequireApproval0? mcpServerToolRequireApproval0 = default;
            global::G.McpServerToolRequireApproval1? mcpServerToolRequireApproval1 = default;
            global::G.McpServerToolRequireApproval2? mcpServerToolRequireApproval2 = default;
            object? mcpServerToolRequireApprovalVariant4 = default;
            object? mcpServerToolRequireApprovalVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        mcpServerToolRequireApproval0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpServerToolRequireApproval0>(__rawJson, options);
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
                        mcpServerToolRequireApproval1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpServerToolRequireApproval1>(__rawJson, options);
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
                        mcpServerToolRequireApproval2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpServerToolRequireApproval2>(__rawJson, options);
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
                        mcpServerToolRequireApprovalVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
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
                        mcpServerToolRequireApprovalVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (mcpServerToolRequireApproval0 == null && mcpServerToolRequireApproval1 == null && mcpServerToolRequireApproval2 == null && mcpServerToolRequireApprovalVariant4 == null && mcpServerToolRequireApprovalVariant5 == null)
            {
                try
                {
                    mcpServerToolRequireApproval0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpServerToolRequireApproval0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpServerToolRequireApproval1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpServerToolRequireApproval1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpServerToolRequireApproval2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpServerToolRequireApproval2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpServerToolRequireApprovalVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpServerToolRequireApprovalVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.McpServerToolRequireApproval(
                mcpServerToolRequireApproval0,

                mcpServerToolRequireApproval1,

                mcpServerToolRequireApproval2,

                mcpServerToolRequireApprovalVariant4,

                mcpServerToolRequireApprovalVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.McpServerToolRequireApproval value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMcpServerToolRequireApproval0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolRequireApproval0, typeof(global::G.McpServerToolRequireApproval0), options);
            }
            else if (value.IsMcpServerToolRequireApproval1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolRequireApproval1, typeof(global::G.McpServerToolRequireApproval1), options);
            }
            else if (value.IsMcpServerToolRequireApproval2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolRequireApproval2, typeof(global::G.McpServerToolRequireApproval2), options);
            }
            else if (value.IsMcpServerToolRequireApprovalVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolRequireApprovalVariant4, typeof(object), options);
            }
            else if (value.IsMcpServerToolRequireApprovalVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolRequireApprovalVariant5, typeof(object), options);
            }
        }
    }
}