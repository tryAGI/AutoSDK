//HintName: G.Models.SystemMessageContentItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SystemMessageContentItemDiscriminatorType
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
    public static class SystemMessageContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemMessageContentItemDiscriminatorType value)
        {
            return value switch
            {
                SystemMessageContentItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                SystemMessageContentItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                SystemMessageContentItemDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                SystemMessageContentItemDiscriminatorType.Code => "code",
                SystemMessageContentItemDiscriminatorType.CodeExecutionResult => "code_execution_result",
                SystemMessageContentItemDiscriminatorType.ImageUrl => "image_url",
                SystemMessageContentItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                SystemMessageContentItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                SystemMessageContentItemDiscriminatorType.McpCall => "mcp_call",
                SystemMessageContentItemDiscriminatorType.McpListTools => "mcp_list_tools",
                SystemMessageContentItemDiscriminatorType.Media => "media",
                SystemMessageContentItemDiscriminatorType.MediaVariable => "media_variable",
                SystemMessageContentItemDiscriminatorType.OutputMedia => "output_media",
                SystemMessageContentItemDiscriminatorType.ServerToolUse => "server_tool_use",
                SystemMessageContentItemDiscriminatorType.ShellCall => "shell_call",
                SystemMessageContentItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                SystemMessageContentItemDiscriminatorType.Text => "text",
                SystemMessageContentItemDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                SystemMessageContentItemDiscriminatorType.Thinking => "thinking",
                SystemMessageContentItemDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemMessageContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => SystemMessageContentItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => SystemMessageContentItemDiscriminatorType.ApplyPatchCallOutput,
                "bash_code_execution_tool_result" => SystemMessageContentItemDiscriminatorType.BashCodeExecutionToolResult,
                "code" => SystemMessageContentItemDiscriminatorType.Code,
                "code_execution_result" => SystemMessageContentItemDiscriminatorType.CodeExecutionResult,
                "image_url" => SystemMessageContentItemDiscriminatorType.ImageUrl,
                "mcp_approval_request" => SystemMessageContentItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => SystemMessageContentItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => SystemMessageContentItemDiscriminatorType.McpCall,
                "mcp_list_tools" => SystemMessageContentItemDiscriminatorType.McpListTools,
                "media" => SystemMessageContentItemDiscriminatorType.Media,
                "media_variable" => SystemMessageContentItemDiscriminatorType.MediaVariable,
                "output_media" => SystemMessageContentItemDiscriminatorType.OutputMedia,
                "server_tool_use" => SystemMessageContentItemDiscriminatorType.ServerToolUse,
                "shell_call" => SystemMessageContentItemDiscriminatorType.ShellCall,
                "shell_call_output" => SystemMessageContentItemDiscriminatorType.ShellCallOutput,
                "text" => SystemMessageContentItemDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => SystemMessageContentItemDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => SystemMessageContentItemDiscriminatorType.Thinking,
                "web_search_tool_result" => SystemMessageContentItemDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}