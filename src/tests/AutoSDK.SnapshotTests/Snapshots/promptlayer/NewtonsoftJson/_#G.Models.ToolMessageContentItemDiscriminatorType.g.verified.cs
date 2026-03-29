//HintName: G.Models.ToolMessageContentItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolMessageContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apply_patch_call")]
        ApplyPatchCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apply_patch_call_output")]
        ApplyPatchCallOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash_code_execution_tool_result")]
        BashCodeExecutionToolResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code")]
        Code,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_execution_result")]
        CodeExecutionResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_approval_request")]
        McpApprovalRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_approval_response")]
        McpApprovalResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_call")]
        McpCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_list_tools")]
        McpListTools,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="media")]
        Media,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="media_variable")]
        MediaVariable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_media")]
        OutputMedia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_tool_use")]
        ServerToolUse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shell_call")]
        ShellCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shell_call_output")]
        ShellCallOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_code_execution_tool_result")]
        TextEditorCodeExecutionToolResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thinking")]
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_tool_result")]
        WebSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageContentItemDiscriminatorType value)
        {
            return value switch
            {
                ToolMessageContentItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                ToolMessageContentItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                ToolMessageContentItemDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                ToolMessageContentItemDiscriminatorType.Code => "code",
                ToolMessageContentItemDiscriminatorType.CodeExecutionResult => "code_execution_result",
                ToolMessageContentItemDiscriminatorType.ImageUrl => "image_url",
                ToolMessageContentItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                ToolMessageContentItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                ToolMessageContentItemDiscriminatorType.McpCall => "mcp_call",
                ToolMessageContentItemDiscriminatorType.McpListTools => "mcp_list_tools",
                ToolMessageContentItemDiscriminatorType.Media => "media",
                ToolMessageContentItemDiscriminatorType.MediaVariable => "media_variable",
                ToolMessageContentItemDiscriminatorType.OutputMedia => "output_media",
                ToolMessageContentItemDiscriminatorType.ServerToolUse => "server_tool_use",
                ToolMessageContentItemDiscriminatorType.ShellCall => "shell_call",
                ToolMessageContentItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                ToolMessageContentItemDiscriminatorType.Text => "text",
                ToolMessageContentItemDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                ToolMessageContentItemDiscriminatorType.Thinking => "thinking",
                ToolMessageContentItemDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => ToolMessageContentItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => ToolMessageContentItemDiscriminatorType.ApplyPatchCallOutput,
                "bash_code_execution_tool_result" => ToolMessageContentItemDiscriminatorType.BashCodeExecutionToolResult,
                "code" => ToolMessageContentItemDiscriminatorType.Code,
                "code_execution_result" => ToolMessageContentItemDiscriminatorType.CodeExecutionResult,
                "image_url" => ToolMessageContentItemDiscriminatorType.ImageUrl,
                "mcp_approval_request" => ToolMessageContentItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => ToolMessageContentItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => ToolMessageContentItemDiscriminatorType.McpCall,
                "mcp_list_tools" => ToolMessageContentItemDiscriminatorType.McpListTools,
                "media" => ToolMessageContentItemDiscriminatorType.Media,
                "media_variable" => ToolMessageContentItemDiscriminatorType.MediaVariable,
                "output_media" => ToolMessageContentItemDiscriminatorType.OutputMedia,
                "server_tool_use" => ToolMessageContentItemDiscriminatorType.ServerToolUse,
                "shell_call" => ToolMessageContentItemDiscriminatorType.ShellCall,
                "shell_call_output" => ToolMessageContentItemDiscriminatorType.ShellCallOutput,
                "text" => ToolMessageContentItemDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => ToolMessageContentItemDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => ToolMessageContentItemDiscriminatorType.Thinking,
                "web_search_tool_result" => ToolMessageContentItemDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}