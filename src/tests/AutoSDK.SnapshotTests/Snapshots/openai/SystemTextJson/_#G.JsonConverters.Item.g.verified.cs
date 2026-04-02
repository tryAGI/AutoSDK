//HintName: G.JsonConverters.Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Item>
    {
        /// <inheritdoc />
        public override global::G.Item Read(
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
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("queries")) __score2++;
            if (__jsonProps.Contains("results")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("action")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("pending_safety_checks")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("acknowledged_safety_checks")) __score4++;
            if (__jsonProps.Contains("call_id")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("output")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("arguments")) __score6++;
            if (__jsonProps.Contains("call_id")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("call_id")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("output")) __score7++;
            if (__jsonProps.Contains("status")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("encrypted_content")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("summary")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("result")) __score9++;
            if (__jsonProps.Contains("status")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("code")) __score10++;
            if (__jsonProps.Contains("container_id")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("results")) __score10++;
            if (__jsonProps.Contains("status")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("action")) __score11++;
            if (__jsonProps.Contains("call_id")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("status")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("output")) __score12++;
            if (__jsonProps.Contains("status")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("error")) __score13++;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("server_label")) __score13++;
            if (__jsonProps.Contains("tools")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("arguments")) __score14++;
            if (__jsonProps.Contains("id")) __score14++;
            if (__jsonProps.Contains("name")) __score14++;
            if (__jsonProps.Contains("server_label")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("approval_request_id")) __score15++;
            if (__jsonProps.Contains("approve")) __score15++;
            if (__jsonProps.Contains("id")) __score15++;
            if (__jsonProps.Contains("reason")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("arguments")) __score16++;
            if (__jsonProps.Contains("error")) __score16++;
            if (__jsonProps.Contains("id")) __score16++;
            if (__jsonProps.Contains("name")) __score16++;
            if (__jsonProps.Contains("output")) __score16++;
            if (__jsonProps.Contains("server_label")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
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
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }

            global::G.InputMessage? message1 = default;
            global::G.OutputMessage? message2 = default;
            global::G.FileSearchToolCall? fileSearchCall = default;
            global::G.ComputerToolCall? computerCall = default;
            global::G.ComputerCallOutputItemParam? computerCallOutput = default;
            global::G.WebSearchToolCall? webSearchCall = default;
            global::G.FunctionToolCall? functionCall = default;
            global::G.FunctionCallOutputItemParam? functionCallOutput = default;
            global::G.ReasoningItem? reasoning = default;
            global::G.ImageGenToolCall? imageGenerationCall = default;
            global::G.CodeInterpreterToolCall? codeInterpreterCall = default;
            global::G.LocalShellToolCall? localShellCall = default;
            global::G.LocalShellToolCallOutput? localShellCallOutput = default;
            global::G.MCPListTools? mcpListTools = default;
            global::G.MCPApprovalRequest? mcpApprovalRequest = default;
            global::G.MCPApprovalResponse? mcpApprovalResponse = default;
            global::G.MCPToolCall? mcpCall = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        message1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessage>(__rawJson, options);
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
                        message2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessage>(__rawJson, options);
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
                        fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileSearchToolCall>(__rawJson, options);
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
                        computerCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCall>(__rawJson, options);
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
                        computerCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerCallOutputItemParam>(__rawJson, options);
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
                        webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchToolCall>(__rawJson, options);
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
                        functionCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCall>(__rawJson, options);
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
                        functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionCallOutputItemParam>(__rawJson, options);
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
                        reasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReasoningItem>(__rawJson, options);
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
                        imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageGenToolCall>(__rawJson, options);
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
                        codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeInterpreterToolCall>(__rawJson, options);
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
                        localShellCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LocalShellToolCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        localShellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LocalShellToolCallOutput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
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
                else if (__bestIndex == 14)
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
                else if (__bestIndex == 15)
                {
                    try
                    {
                        mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPApprovalResponse>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
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
            }

            if (message1 == null && message2 == null && fileSearchCall == null && computerCall == null && computerCallOutput == null && webSearchCall == null && functionCall == null && functionCallOutput == null && reasoning == null && imageGenerationCall == null && codeInterpreterCall == null && localShellCall == null && localShellCallOutput == null && mcpListTools == null && mcpApprovalRequest == null && mcpApprovalResponse == null && mcpCall == null)
            {
                try
                {
                    message1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    message2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessage>(__rawJson, options);
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
                    computerCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerCallOutputItemParam>(__rawJson, options);
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
                    functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionCallOutputItemParam>(__rawJson, options);
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
                    localShellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LocalShellToolCallOutput>(__rawJson, options);
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

                try
                {
                    mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPApprovalResponse>(__rawJson, options);
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
            }

            var __value = new global::G.Item(
                message1,

                message2,

                fileSearchCall,

                computerCall,

                computerCallOutput,

                webSearchCall,

                functionCall,

                functionCallOutput,

                reasoning,

                imageGenerationCall,

                codeInterpreterCall,

                localShellCall,

                localShellCallOutput,

                mcpListTools,

                mcpApprovalRequest,

                mcpApprovalResponse,

                mcpCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessage1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message1, typeof(global::G.InputMessage), options);
            }
            else if (value.IsMessage2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message2, typeof(global::G.OutputMessage), options);
            }
            else if (value.IsFileSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall, typeof(global::G.FileSearchToolCall), options);
            }
            else if (value.IsComputerCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall, typeof(global::G.ComputerToolCall), options);
            }
            else if (value.IsComputerCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCallOutput, typeof(global::G.ComputerCallOutputItemParam), options);
            }
            else if (value.IsWebSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall, typeof(global::G.WebSearchToolCall), options);
            }
            else if (value.IsFunctionCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall, typeof(global::G.FunctionToolCall), options);
            }
            else if (value.IsFunctionCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutput, typeof(global::G.FunctionCallOutputItemParam), options);
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
            else if (value.IsLocalShellCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShellCallOutput, typeof(global::G.LocalShellToolCallOutput), options);
            }
            else if (value.IsMcpListTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListTools, typeof(global::G.MCPListTools), options);
            }
            else if (value.IsMcpApprovalRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequest, typeof(global::G.MCPApprovalRequest), options);
            }
            else if (value.IsMcpApprovalResponse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse, typeof(global::G.MCPApprovalResponse), options);
            }
            else if (value.IsMcpCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall, typeof(global::G.MCPToolCall), options);
            }
        }
    }
}