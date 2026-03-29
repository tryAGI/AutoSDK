//HintName: G.Models.UserMessageContentItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserMessageContentItemDiscriminatorType
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
    public static class UserMessageContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageContentItemDiscriminatorType value)
        {
            return value switch
            {
                UserMessageContentItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                UserMessageContentItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                UserMessageContentItemDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                UserMessageContentItemDiscriminatorType.Code => "code",
                UserMessageContentItemDiscriminatorType.CodeExecutionResult => "code_execution_result",
                UserMessageContentItemDiscriminatorType.ImageUrl => "image_url",
                UserMessageContentItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                UserMessageContentItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                UserMessageContentItemDiscriminatorType.McpCall => "mcp_call",
                UserMessageContentItemDiscriminatorType.McpListTools => "mcp_list_tools",
                UserMessageContentItemDiscriminatorType.Media => "media",
                UserMessageContentItemDiscriminatorType.MediaVariable => "media_variable",
                UserMessageContentItemDiscriminatorType.OutputMedia => "output_media",
                UserMessageContentItemDiscriminatorType.ServerToolUse => "server_tool_use",
                UserMessageContentItemDiscriminatorType.ShellCall => "shell_call",
                UserMessageContentItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                UserMessageContentItemDiscriminatorType.Text => "text",
                UserMessageContentItemDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                UserMessageContentItemDiscriminatorType.Thinking => "thinking",
                UserMessageContentItemDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => UserMessageContentItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => UserMessageContentItemDiscriminatorType.ApplyPatchCallOutput,
                "bash_code_execution_tool_result" => UserMessageContentItemDiscriminatorType.BashCodeExecutionToolResult,
                "code" => UserMessageContentItemDiscriminatorType.Code,
                "code_execution_result" => UserMessageContentItemDiscriminatorType.CodeExecutionResult,
                "image_url" => UserMessageContentItemDiscriminatorType.ImageUrl,
                "mcp_approval_request" => UserMessageContentItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => UserMessageContentItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => UserMessageContentItemDiscriminatorType.McpCall,
                "mcp_list_tools" => UserMessageContentItemDiscriminatorType.McpListTools,
                "media" => UserMessageContentItemDiscriminatorType.Media,
                "media_variable" => UserMessageContentItemDiscriminatorType.MediaVariable,
                "output_media" => UserMessageContentItemDiscriminatorType.OutputMedia,
                "server_tool_use" => UserMessageContentItemDiscriminatorType.ServerToolUse,
                "shell_call" => UserMessageContentItemDiscriminatorType.ShellCall,
                "shell_call_output" => UserMessageContentItemDiscriminatorType.ShellCallOutput,
                "text" => UserMessageContentItemDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => UserMessageContentItemDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => UserMessageContentItemDiscriminatorType.Thinking,
                "web_search_tool_result" => UserMessageContentItemDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}