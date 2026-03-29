//HintName: G.Models.CompletionPromptContentItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionPromptContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCall,
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCallOutput,
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResult,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionResult,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        McpApprovalRequest,
        /// <summary>
        /// 
        /// </summary>
        McpApprovalResponse,
        /// <summary>
        /// 
        /// </summary>
        McpCall,
        /// <summary>
        /// 
        /// </summary>
        McpListTools,
        /// <summary>
        /// 
        /// </summary>
        Media,
        /// <summary>
        /// 
        /// </summary>
        MediaVariable,
        /// <summary>
        /// 
        /// </summary>
        OutputMedia,
        /// <summary>
        /// 
        /// </summary>
        ServerToolUse,
        /// <summary>
        /// 
        /// </summary>
        ShellCall,
        /// <summary>
        /// 
        /// </summary>
        ShellCallOutput,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionToolResult,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionPromptContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionPromptContentItemDiscriminatorType value)
        {
            return value switch
            {
                CompletionPromptContentItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                CompletionPromptContentItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                CompletionPromptContentItemDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                CompletionPromptContentItemDiscriminatorType.Code => "code",
                CompletionPromptContentItemDiscriminatorType.CodeExecutionResult => "code_execution_result",
                CompletionPromptContentItemDiscriminatorType.ImageUrl => "image_url",
                CompletionPromptContentItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                CompletionPromptContentItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                CompletionPromptContentItemDiscriminatorType.McpCall => "mcp_call",
                CompletionPromptContentItemDiscriminatorType.McpListTools => "mcp_list_tools",
                CompletionPromptContentItemDiscriminatorType.Media => "media",
                CompletionPromptContentItemDiscriminatorType.MediaVariable => "media_variable",
                CompletionPromptContentItemDiscriminatorType.OutputMedia => "output_media",
                CompletionPromptContentItemDiscriminatorType.ServerToolUse => "server_tool_use",
                CompletionPromptContentItemDiscriminatorType.ShellCall => "shell_call",
                CompletionPromptContentItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                CompletionPromptContentItemDiscriminatorType.Text => "text",
                CompletionPromptContentItemDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                CompletionPromptContentItemDiscriminatorType.Thinking => "thinking",
                CompletionPromptContentItemDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionPromptContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => CompletionPromptContentItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => CompletionPromptContentItemDiscriminatorType.ApplyPatchCallOutput,
                "bash_code_execution_tool_result" => CompletionPromptContentItemDiscriminatorType.BashCodeExecutionToolResult,
                "code" => CompletionPromptContentItemDiscriminatorType.Code,
                "code_execution_result" => CompletionPromptContentItemDiscriminatorType.CodeExecutionResult,
                "image_url" => CompletionPromptContentItemDiscriminatorType.ImageUrl,
                "mcp_approval_request" => CompletionPromptContentItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => CompletionPromptContentItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => CompletionPromptContentItemDiscriminatorType.McpCall,
                "mcp_list_tools" => CompletionPromptContentItemDiscriminatorType.McpListTools,
                "media" => CompletionPromptContentItemDiscriminatorType.Media,
                "media_variable" => CompletionPromptContentItemDiscriminatorType.MediaVariable,
                "output_media" => CompletionPromptContentItemDiscriminatorType.OutputMedia,
                "server_tool_use" => CompletionPromptContentItemDiscriminatorType.ServerToolUse,
                "shell_call" => CompletionPromptContentItemDiscriminatorType.ShellCall,
                "shell_call_output" => CompletionPromptContentItemDiscriminatorType.ShellCallOutput,
                "text" => CompletionPromptContentItemDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => CompletionPromptContentItemDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => CompletionPromptContentItemDiscriminatorType.Thinking,
                "web_search_tool_result" => CompletionPromptContentItemDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}