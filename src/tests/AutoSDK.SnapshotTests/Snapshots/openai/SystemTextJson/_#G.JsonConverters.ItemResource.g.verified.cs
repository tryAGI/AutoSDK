//HintName: G.JsonConverters.ItemResource.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ItemResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ItemResource>
    {
        /// <inheritdoc />
        public override global::G.ItemResource Read(
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
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            var __score7 = 0;
            var __score8 = 0;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("result")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("code")) __score9++;
            if (__jsonProps.Contains("container_id")) __score9++;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("results")) __score9++;
            if (__jsonProps.Contains("status")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("action")) __score10++;
            if (__jsonProps.Contains("call_id")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("status")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("output")) __score11++;
            if (__jsonProps.Contains("status")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("error")) __score12++;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("server_label")) __score12++;
            if (__jsonProps.Contains("tools")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("arguments")) __score13++;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("name")) __score13++;
            if (__jsonProps.Contains("server_label")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("approval_request_id")) __score14++;
            if (__jsonProps.Contains("approve")) __score14++;
            if (__jsonProps.Contains("id")) __score14++;
            if (__jsonProps.Contains("reason")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("arguments")) __score15++;
            if (__jsonProps.Contains("error")) __score15++;
            if (__jsonProps.Contains("id")) __score15++;
            if (__jsonProps.Contains("name")) __score15++;
            if (__jsonProps.Contains("output")) __score15++;
            if (__jsonProps.Contains("server_label")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
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

            global::G.InputMessageResource? inputMessage = default;
            global::G.OutputMessage? message = default;
            global::G.FileSearchToolCall? fileSearchCall = default;
            global::G.ComputerToolCall? computerCall = default;
            global::G.ComputerToolCallOutputResource? computerToolCallOutput = default;
            global::G.WebSearchToolCall? webSearchCall = default;
            global::G.FunctionToolCallResource? functionToolCall = default;
            global::G.FunctionToolCallOutputResource? functionToolCallOutput = default;
            global::G.ImageGenToolCall? imageGenerationCall = default;
            global::G.CodeInterpreterToolCall? codeInterpreterCall = default;
            global::G.LocalShellToolCall? localShellCall = default;
            global::G.LocalShellToolCallOutput? localShellCallOutput = default;
            global::G.MCPListTools? mcpListTools = default;
            global::G.MCPApprovalRequest? mcpApprovalRequest = default;
            global::G.MCPApprovalResponseResource? mcpApprovalResponse = default;
            global::G.MCPToolCall? mcpCall = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        inputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageResource>(__rawJson, options);
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
                        message = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessage>(__rawJson, options);
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
                        computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCallOutputResource>(__rawJson, options);
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
                        functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCallResource>(__rawJson, options);
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
                        functionToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCallOutputResource>(__rawJson, options);
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
                        imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageGenToolCall>(__rawJson, options);
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
                        codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeInterpreterToolCall>(__rawJson, options);
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
                        localShellCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LocalShellToolCall>(__rawJson, options);
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
                        localShellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LocalShellToolCallOutput>(__rawJson, options);
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
                        mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPListTools>(__rawJson, options);
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
                        mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPApprovalRequest>(__rawJson, options);
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
                        mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPApprovalResponseResource>(__rawJson, options);
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

            if (inputMessage == null && message == null && fileSearchCall == null && computerCall == null && computerToolCallOutput == null && webSearchCall == null && functionToolCall == null && functionToolCallOutput == null && imageGenerationCall == null && codeInterpreterCall == null && localShellCall == null && localShellCallOutput == null && mcpListTools == null && mcpApprovalRequest == null && mcpApprovalResponse == null && mcpCall == null)
            {
                try
                {
                    inputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

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
                    computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCallOutputResource>(__rawJson, options);
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
                    functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCallResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCallOutputResource>(__rawJson, options);
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
                    mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPApprovalResponseResource>(__rawJson, options);
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

            var __value = new global::G.ItemResource(
                inputMessage,

                message,

                fileSearchCall,

                computerCall,

                computerToolCallOutput,

                webSearchCall,

                functionToolCall,

                functionToolCallOutput,

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
            global::G.ItemResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInputMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessage, typeof(global::G.InputMessageResource), options);
            }
            else if (value.IsMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeof(global::G.OutputMessage), options);
            }
            else if (value.IsFileSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall, typeof(global::G.FileSearchToolCall), options);
            }
            else if (value.IsComputerCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall, typeof(global::G.ComputerToolCall), options);
            }
            else if (value.IsComputerToolCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCallOutput, typeof(global::G.ComputerToolCallOutputResource), options);
            }
            else if (value.IsWebSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall, typeof(global::G.WebSearchToolCall), options);
            }
            else if (value.IsFunctionToolCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCall, typeof(global::G.FunctionToolCallResource), options);
            }
            else if (value.IsFunctionToolCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCallOutput, typeof(global::G.FunctionToolCallOutputResource), options);
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse, typeof(global::G.MCPApprovalResponseResource), options);
            }
            else if (value.IsMcpCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall, typeof(global::G.MCPToolCall), options);
            }
        }
    }
}