//HintName: G.JsonConverters.OutputItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputItem>
    {
        /// <inheritdoc />
        public override global::G.OutputItem Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("queries")) __score1++;
            if (__jsonProps.Contains("results")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("arguments")) __score2++;
            if (__jsonProps.Contains("call_id")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("action")) __score4++;
            if (__jsonProps.Contains("call_id")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("pending_safety_checks")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("encrypted_content")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("summary")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("result")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("code")) __score7++;
            if (__jsonProps.Contains("container_id")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("results")) __score7++;
            if (__jsonProps.Contains("status")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("action")) __score8++;
            if (__jsonProps.Contains("call_id")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("arguments")) __score9++;
            if (__jsonProps.Contains("error")) __score9++;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("output")) __score9++;
            if (__jsonProps.Contains("server_label")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("error")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("server_label")) __score10++;
            if (__jsonProps.Contains("tools")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("arguments")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("name")) __score11++;
            if (__jsonProps.Contains("server_label")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
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
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }

            global::G.OutputMessage? message = default;
            global::G.FileSearchToolCall? fileSearchCall = default;
            global::G.FunctionToolCall? functionCall = default;
            global::G.WebSearchToolCall? webSearchCall = default;
            global::G.ComputerToolCall? computerCall = default;
            global::G.ReasoningItem? reasoning = default;
            global::G.ImageGenToolCall? imageGenerationCall = default;
            global::G.CodeInterpreterToolCall? codeInterpreterCall = default;
            global::G.LocalShellToolCall? localShellCall = default;
            global::G.MCPToolCall? mcpCall = default;
            global::G.MCPListTools? mcpListTools = default;
            global::G.MCPApprovalRequest? mcpApprovalRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        message = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessage>(__rawJson, options);
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
                        fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileSearchToolCall>(__rawJson, options);
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
                        functionCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCall>(__rawJson, options);
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
                        webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchToolCall>(__rawJson, options);
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
                        computerCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCall>(__rawJson, options);
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
                        reasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReasoningItem>(__rawJson, options);
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
                        imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageGenToolCall>(__rawJson, options);
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
                        codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeInterpreterToolCall>(__rawJson, options);
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
                        localShellCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LocalShellToolCall>(__rawJson, options);
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
                        mcpCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPToolCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPListTools>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPApprovalRequest>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (message == null && fileSearchCall == null && functionCall == null && webSearchCall == null && computerCall == null && reasoning == null && imageGenerationCall == null && codeInterpreterCall == null && localShellCall == null && mcpCall == null && mcpListTools == null && mcpApprovalRequest == null)
            {
                try
                {
                    message = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileSearchToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    reasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReasoningItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageGenToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeInterpreterToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    localShellCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LocalShellToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPListTools>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPApprovalRequest>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OutputItem(
                message,

                fileSearchCall,

                functionCall,

                webSearchCall,

                computerCall,

                reasoning,

                imageGenerationCall,

                codeInterpreterCall,

                localShellCall,

                mcpCall,

                mcpListTools,

                mcpApprovalRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeof(global::G.OutputMessage), options);
            }
            else if (value.IsFileSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall, typeof(global::G.FileSearchToolCall), options);
            }
            else if (value.IsFunctionCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall, typeof(global::G.FunctionToolCall), options);
            }
            else if (value.IsWebSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall, typeof(global::G.WebSearchToolCall), options);
            }
            else if (value.IsComputerCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall, typeof(global::G.ComputerToolCall), options);
            }
            else if (value.IsReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning, typeof(global::G.ReasoningItem), options);
            }
            else if (value.IsImageGenerationCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationCall, typeof(global::G.ImageGenToolCall), options);
            }
            else if (value.IsCodeInterpreterCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCall, typeof(global::G.CodeInterpreterToolCall), options);
            }
            else if (value.IsLocalShellCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShellCall, typeof(global::G.LocalShellToolCall), options);
            }
            else if (value.IsMcpCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall, typeof(global::G.MCPToolCall), options);
            }
            else if (value.IsMcpListTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListTools, typeof(global::G.MCPListTools), options);
            }
            else if (value.IsMcpApprovalRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequest, typeof(global::G.MCPApprovalRequest), options);
            }
        }
    }
}