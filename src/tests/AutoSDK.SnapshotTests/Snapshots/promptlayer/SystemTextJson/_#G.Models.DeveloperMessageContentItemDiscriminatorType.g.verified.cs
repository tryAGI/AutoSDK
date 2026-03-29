//HintName: G.Models.DeveloperMessageContentItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeveloperMessageContentItemDiscriminatorType
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
    public static class DeveloperMessageContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeveloperMessageContentItemDiscriminatorType value)
        {
            return value switch
            {
                DeveloperMessageContentItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                DeveloperMessageContentItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                DeveloperMessageContentItemDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                DeveloperMessageContentItemDiscriminatorType.Code => "code",
                DeveloperMessageContentItemDiscriminatorType.CodeExecutionResult => "code_execution_result",
                DeveloperMessageContentItemDiscriminatorType.ImageUrl => "image_url",
                DeveloperMessageContentItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                DeveloperMessageContentItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                DeveloperMessageContentItemDiscriminatorType.McpCall => "mcp_call",
                DeveloperMessageContentItemDiscriminatorType.McpListTools => "mcp_list_tools",
                DeveloperMessageContentItemDiscriminatorType.Media => "media",
                DeveloperMessageContentItemDiscriminatorType.MediaVariable => "media_variable",
                DeveloperMessageContentItemDiscriminatorType.OutputMedia => "output_media",
                DeveloperMessageContentItemDiscriminatorType.ServerToolUse => "server_tool_use",
                DeveloperMessageContentItemDiscriminatorType.ShellCall => "shell_call",
                DeveloperMessageContentItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                DeveloperMessageContentItemDiscriminatorType.Text => "text",
                DeveloperMessageContentItemDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                DeveloperMessageContentItemDiscriminatorType.Thinking => "thinking",
                DeveloperMessageContentItemDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeveloperMessageContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => DeveloperMessageContentItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => DeveloperMessageContentItemDiscriminatorType.ApplyPatchCallOutput,
                "bash_code_execution_tool_result" => DeveloperMessageContentItemDiscriminatorType.BashCodeExecutionToolResult,
                "code" => DeveloperMessageContentItemDiscriminatorType.Code,
                "code_execution_result" => DeveloperMessageContentItemDiscriminatorType.CodeExecutionResult,
                "image_url" => DeveloperMessageContentItemDiscriminatorType.ImageUrl,
                "mcp_approval_request" => DeveloperMessageContentItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => DeveloperMessageContentItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => DeveloperMessageContentItemDiscriminatorType.McpCall,
                "mcp_list_tools" => DeveloperMessageContentItemDiscriminatorType.McpListTools,
                "media" => DeveloperMessageContentItemDiscriminatorType.Media,
                "media_variable" => DeveloperMessageContentItemDiscriminatorType.MediaVariable,
                "output_media" => DeveloperMessageContentItemDiscriminatorType.OutputMedia,
                "server_tool_use" => DeveloperMessageContentItemDiscriminatorType.ServerToolUse,
                "shell_call" => DeveloperMessageContentItemDiscriminatorType.ShellCall,
                "shell_call_output" => DeveloperMessageContentItemDiscriminatorType.ShellCallOutput,
                "text" => DeveloperMessageContentItemDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => DeveloperMessageContentItemDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => DeveloperMessageContentItemDiscriminatorType.Thinking,
                "web_search_tool_result" => DeveloperMessageContentItemDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}