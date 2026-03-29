//HintName: G.Models.AssistantMessageContentVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantMessageContentVariant1ItemDiscriminatorType
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
    public static class AssistantMessageContentVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageContentVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                AssistantMessageContentVariant1ItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                AssistantMessageContentVariant1ItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                AssistantMessageContentVariant1ItemDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                AssistantMessageContentVariant1ItemDiscriminatorType.Code => "code",
                AssistantMessageContentVariant1ItemDiscriminatorType.CodeExecutionResult => "code_execution_result",
                AssistantMessageContentVariant1ItemDiscriminatorType.ImageUrl => "image_url",
                AssistantMessageContentVariant1ItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                AssistantMessageContentVariant1ItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                AssistantMessageContentVariant1ItemDiscriminatorType.McpCall => "mcp_call",
                AssistantMessageContentVariant1ItemDiscriminatorType.McpListTools => "mcp_list_tools",
                AssistantMessageContentVariant1ItemDiscriminatorType.Media => "media",
                AssistantMessageContentVariant1ItemDiscriminatorType.MediaVariable => "media_variable",
                AssistantMessageContentVariant1ItemDiscriminatorType.OutputMedia => "output_media",
                AssistantMessageContentVariant1ItemDiscriminatorType.ServerToolUse => "server_tool_use",
                AssistantMessageContentVariant1ItemDiscriminatorType.ShellCall => "shell_call",
                AssistantMessageContentVariant1ItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                AssistantMessageContentVariant1ItemDiscriminatorType.Text => "text",
                AssistantMessageContentVariant1ItemDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                AssistantMessageContentVariant1ItemDiscriminatorType.Thinking => "thinking",
                AssistantMessageContentVariant1ItemDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageContentVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => AssistantMessageContentVariant1ItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => AssistantMessageContentVariant1ItemDiscriminatorType.ApplyPatchCallOutput,
                "bash_code_execution_tool_result" => AssistantMessageContentVariant1ItemDiscriminatorType.BashCodeExecutionToolResult,
                "code" => AssistantMessageContentVariant1ItemDiscriminatorType.Code,
                "code_execution_result" => AssistantMessageContentVariant1ItemDiscriminatorType.CodeExecutionResult,
                "image_url" => AssistantMessageContentVariant1ItemDiscriminatorType.ImageUrl,
                "mcp_approval_request" => AssistantMessageContentVariant1ItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => AssistantMessageContentVariant1ItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => AssistantMessageContentVariant1ItemDiscriminatorType.McpCall,
                "mcp_list_tools" => AssistantMessageContentVariant1ItemDiscriminatorType.McpListTools,
                "media" => AssistantMessageContentVariant1ItemDiscriminatorType.Media,
                "media_variable" => AssistantMessageContentVariant1ItemDiscriminatorType.MediaVariable,
                "output_media" => AssistantMessageContentVariant1ItemDiscriminatorType.OutputMedia,
                "server_tool_use" => AssistantMessageContentVariant1ItemDiscriminatorType.ServerToolUse,
                "shell_call" => AssistantMessageContentVariant1ItemDiscriminatorType.ShellCall,
                "shell_call_output" => AssistantMessageContentVariant1ItemDiscriminatorType.ShellCallOutput,
                "text" => AssistantMessageContentVariant1ItemDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => AssistantMessageContentVariant1ItemDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => AssistantMessageContentVariant1ItemDiscriminatorType.Thinking,
                "web_search_tool_result" => AssistantMessageContentVariant1ItemDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}