//HintName: G.JsonConverters.ContentItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentItem>
    {
        /// <inheritdoc />
        public override global::G.ContentItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CompletionPromptContentItemDiscriminator>(ref readerCopy, options);

            global::G.TextContent? text = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextContent>(ref reader, options);
            }
            global::G.ThinkingContent? thinking = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ThinkingContent>(ref reader, options);
            }
            global::G.CodeContent? code = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeContent>(ref reader, options);
            }
            global::G.ImageContent? imageUrl = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageContent>(ref reader, options);
            }
            global::G.MediaContent? media = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.Media)
            {
                media = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MediaContent>(ref reader, options);
            }
            global::G.MediaVariable? mediaVariable = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.MediaVariable)
            {
                mediaVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MediaVariable>(ref reader, options);
            }
            global::G.OutputMediaContent? outputMedia = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.OutputMedia)
            {
                outputMedia = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMediaContent>(ref reader, options);
            }
            global::G.ServerToolUseContent? serverToolUse = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ServerToolUse)
            {
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ServerToolUseContent>(ref reader, options);
            }
            global::G.WebSearchToolResultContent? webSearchToolResult = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.WebSearchToolResult)
            {
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchToolResultContent>(ref reader, options);
            }
            global::G.CodeExecutionResultContent? codeExecutionResult = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.CodeExecutionResult)
            {
                codeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeExecutionResultContent>(ref reader, options);
            }
            global::G.McpListToolsContent? mcpListTools = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.McpListTools)
            {
                mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpListToolsContent>(ref reader, options);
            }
            global::G.McpCallContent? mcpCall = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.McpCall)
            {
                mcpCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpCallContent>(ref reader, options);
            }
            global::G.McpApprovalRequestContent? mcpApprovalRequest = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.McpApprovalRequest)
            {
                mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpApprovalRequestContent>(ref reader, options);
            }
            global::G.McpApprovalResponseContent? mcpApprovalResponse = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.McpApprovalResponse)
            {
                mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpApprovalResponseContent>(ref reader, options);
            }
            global::G.BashCodeExecutionToolResultContent? bashCodeExecutionToolResult = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.BashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BashCodeExecutionToolResultContent>(ref reader, options);
            }
            global::G.TextEditorCodeExecutionToolResultContent? textEditorCodeExecutionToolResult = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.TextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextEditorCodeExecutionToolResultContent>(ref reader, options);
            }
            global::G.ShellCallContent? shellCall = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ShellCall)
            {
                shellCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ShellCallContent>(ref reader, options);
            }
            global::G.ShellCallOutputContent? shellCallOutput = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ShellCallOutput)
            {
                shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ShellCallOutputContent>(ref reader, options);
            }
            global::G.ApplyPatchCallContent? applyPatchCall = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ApplyPatchCall)
            {
                applyPatchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApplyPatchCallContent>(ref reader, options);
            }
            global::G.ApplyPatchCallOutputContent? applyPatchCallOutput = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ApplyPatchCallOutput)
            {
                applyPatchCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApplyPatchCallOutputContent>(ref reader, options);
            }

            var __value = new global::G.ContentItem(
                discriminator?.Type,
                text,

                thinking,

                code,

                imageUrl,

                media,

                mediaVariable,

                outputMedia,

                serverToolUse,

                webSearchToolResult,

                codeExecutionResult,

                mcpListTools,

                mcpCall,

                mcpApprovalRequest,

                mcpApprovalResponse,

                bashCodeExecutionToolResult,

                textEditorCodeExecutionToolResult,

                shellCall,

                shellCallOutput,

                applyPatchCall,

                applyPatchCallOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextContent), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::G.ThinkingContent), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::G.CodeContent), options);
            }
            else if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::G.ImageContent), options);
            }
            else if (value.IsMedia)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Media, typeof(global::G.MediaContent), options);
            }
            else if (value.IsMediaVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MediaVariable, typeof(global::G.MediaVariable), options);
            }
            else if (value.IsOutputMedia)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMedia, typeof(global::G.OutputMediaContent), options);
            }
            else if (value.IsServerToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse, typeof(global::G.ServerToolUseContent), options);
            }
            else if (value.IsWebSearchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult, typeof(global::G.WebSearchToolResultContent), options);
            }
            else if (value.IsCodeExecutionResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionResult, typeof(global::G.CodeExecutionResultContent), options);
            }
            else if (value.IsMcpListTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListTools, typeof(global::G.McpListToolsContent), options);
            }
            else if (value.IsMcpCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall, typeof(global::G.McpCallContent), options);
            }
            else if (value.IsMcpApprovalRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequest, typeof(global::G.McpApprovalRequestContent), options);
            }
            else if (value.IsMcpApprovalResponse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse, typeof(global::G.McpApprovalResponseContent), options);
            }
            else if (value.IsBashCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionToolResult, typeof(global::G.BashCodeExecutionToolResultContent), options);
            }
            else if (value.IsTextEditorCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionToolResult, typeof(global::G.TextEditorCodeExecutionToolResultContent), options);
            }
            else if (value.IsShellCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCall, typeof(global::G.ShellCallContent), options);
            }
            else if (value.IsShellCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCallOutput, typeof(global::G.ShellCallOutputContent), options);
            }
            else if (value.IsApplyPatchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCall, typeof(global::G.ApplyPatchCallContent), options);
            }
            else if (value.IsApplyPatchCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCallOutput, typeof(global::G.ApplyPatchCallOutputContent), options);
            }
        }
    }
}