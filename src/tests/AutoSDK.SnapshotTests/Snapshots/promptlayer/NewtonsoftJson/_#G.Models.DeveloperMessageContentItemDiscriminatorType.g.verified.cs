//HintName: G.Models.DeveloperMessageContentItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeveloperMessageContentItemDiscriminatorType
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