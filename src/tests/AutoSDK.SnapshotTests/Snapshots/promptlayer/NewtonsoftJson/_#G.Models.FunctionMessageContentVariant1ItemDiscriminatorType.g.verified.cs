//HintName: G.Models.FunctionMessageContentVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionMessageContentVariant1ItemDiscriminatorType
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
    public static class FunctionMessageContentVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionMessageContentVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                FunctionMessageContentVariant1ItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                FunctionMessageContentVariant1ItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                FunctionMessageContentVariant1ItemDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                FunctionMessageContentVariant1ItemDiscriminatorType.Code => "code",
                FunctionMessageContentVariant1ItemDiscriminatorType.CodeExecutionResult => "code_execution_result",
                FunctionMessageContentVariant1ItemDiscriminatorType.ImageUrl => "image_url",
                FunctionMessageContentVariant1ItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                FunctionMessageContentVariant1ItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                FunctionMessageContentVariant1ItemDiscriminatorType.McpCall => "mcp_call",
                FunctionMessageContentVariant1ItemDiscriminatorType.McpListTools => "mcp_list_tools",
                FunctionMessageContentVariant1ItemDiscriminatorType.Media => "media",
                FunctionMessageContentVariant1ItemDiscriminatorType.MediaVariable => "media_variable",
                FunctionMessageContentVariant1ItemDiscriminatorType.OutputMedia => "output_media",
                FunctionMessageContentVariant1ItemDiscriminatorType.ServerToolUse => "server_tool_use",
                FunctionMessageContentVariant1ItemDiscriminatorType.ShellCall => "shell_call",
                FunctionMessageContentVariant1ItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                FunctionMessageContentVariant1ItemDiscriminatorType.Text => "text",
                FunctionMessageContentVariant1ItemDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                FunctionMessageContentVariant1ItemDiscriminatorType.Thinking => "thinking",
                FunctionMessageContentVariant1ItemDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionMessageContentVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => FunctionMessageContentVariant1ItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => FunctionMessageContentVariant1ItemDiscriminatorType.ApplyPatchCallOutput,
                "bash_code_execution_tool_result" => FunctionMessageContentVariant1ItemDiscriminatorType.BashCodeExecutionToolResult,
                "code" => FunctionMessageContentVariant1ItemDiscriminatorType.Code,
                "code_execution_result" => FunctionMessageContentVariant1ItemDiscriminatorType.CodeExecutionResult,
                "image_url" => FunctionMessageContentVariant1ItemDiscriminatorType.ImageUrl,
                "mcp_approval_request" => FunctionMessageContentVariant1ItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => FunctionMessageContentVariant1ItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => FunctionMessageContentVariant1ItemDiscriminatorType.McpCall,
                "mcp_list_tools" => FunctionMessageContentVariant1ItemDiscriminatorType.McpListTools,
                "media" => FunctionMessageContentVariant1ItemDiscriminatorType.Media,
                "media_variable" => FunctionMessageContentVariant1ItemDiscriminatorType.MediaVariable,
                "output_media" => FunctionMessageContentVariant1ItemDiscriminatorType.OutputMedia,
                "server_tool_use" => FunctionMessageContentVariant1ItemDiscriminatorType.ServerToolUse,
                "shell_call" => FunctionMessageContentVariant1ItemDiscriminatorType.ShellCall,
                "shell_call_output" => FunctionMessageContentVariant1ItemDiscriminatorType.ShellCallOutput,
                "text" => FunctionMessageContentVariant1ItemDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => FunctionMessageContentVariant1ItemDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => FunctionMessageContentVariant1ItemDiscriminatorType.Thinking,
                "web_search_tool_result" => FunctionMessageContentVariant1ItemDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}