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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.InputMessage? message1 = default;
            if (discriminator?.Type == "message")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InputMessage)}");
                message1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OutputMessage? message2 = default;
            if (discriminator?.Type == "message")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OutputMessage)}");
                message2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FileSearchToolCall? fileSearchCall = default;
            if (discriminator?.Type == "file_search_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FileSearchToolCall)}");
                fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ComputerToolCall? computerCall = default;
            if (discriminator?.Type == "computer_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ComputerToolCall)}");
                computerCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ComputerCallOutputItemParam? computerCallOutput = default;
            if (discriminator?.Type == "computer_call_output")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerCallOutputItemParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ComputerCallOutputItemParam)}");
                computerCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebSearchToolCall? webSearchCall = default;
            if (discriminator?.Type == "web_search_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSearchToolCall)}");
                webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FunctionToolCall? functionCall = default;
            if (discriminator?.Type == "function_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FunctionToolCall)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FunctionCallOutputItemParam? functionCallOutput = default;
            if (discriminator?.Type == "function_call_output")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallOutputItemParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FunctionCallOutputItemParam)}");
                functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ReasoningItem? reasoning = default;
            if (discriminator?.Type == "reasoning")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ReasoningItem)}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageGenToolCall? imageGenerationCall = default;
            if (discriminator?.Type == "image_generation_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageGenToolCall)}");
                imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CodeInterpreterToolCall? codeInterpreterCall = default;
            if (discriminator?.Type == "code_interpreter_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CodeInterpreterToolCall)}");
                codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LocalShellToolCall? localShellCall = default;
            if (discriminator?.Type == "local_shell_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalShellToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalShellToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LocalShellToolCall)}");
                localShellCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LocalShellToolCallOutput? localShellCallOutput = default;
            if (discriminator?.Type == "local_shell_call_output")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalShellToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalShellToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LocalShellToolCallOutput)}");
                localShellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MCPListTools? mcpListTools = default;
            if (discriminator?.Type == "mcp_list_tools")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPListTools), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPListTools> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MCPListTools)}");
                mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MCPApprovalRequest? mcpApprovalRequest = default;
            if (discriminator?.Type == "mcp_approval_request")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPApprovalRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPApprovalRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MCPApprovalRequest)}");
                mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MCPApprovalResponse? mcpApprovalResponse = default;
            if (discriminator?.Type == "mcp_approval_response")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPApprovalResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPApprovalResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MCPApprovalResponse)}");
                mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MCPToolCall? mcpCall = default;
            if (discriminator?.Type == "mcp_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MCPToolCall)}");
                mcpCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Item(
                discriminator?.Type,
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message1!, typeInfo);
            }
            else if (value.IsMessage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message2!, typeInfo);
            }
            else if (value.IsFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall!, typeInfo);
            }
            else if (value.IsComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall!, typeInfo);
            }
            else if (value.IsComputerCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerCallOutputItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerCallOutputItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCallOutput!, typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall!, typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall!, typeInfo);
            }
            else if (value.IsFunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallOutputItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionCallOutputItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutput!, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning!, typeInfo);
            }
            else if (value.IsImageGenerationCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationCall!, typeInfo);
            }
            else if (value.IsCodeInterpreterCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCall!, typeInfo);
            }
            else if (value.IsLocalShellCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalShellToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalShellToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalShellToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShellCall!, typeInfo);
            }
            else if (value.IsLocalShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalShellToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalShellToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalShellToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShellCallOutput!, typeInfo);
            }
            else if (value.IsMcpListTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPListTools), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPListTools?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPListTools).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListTools!, typeInfo);
            }
            else if (value.IsMcpApprovalRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPApprovalRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPApprovalRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPApprovalRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequest!, typeInfo);
            }
            else if (value.IsMcpApprovalResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPApprovalResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPApprovalResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPApprovalResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse!, typeInfo);
            }
            else if (value.IsMcpCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall!, typeInfo);
            }
        }
    }
}