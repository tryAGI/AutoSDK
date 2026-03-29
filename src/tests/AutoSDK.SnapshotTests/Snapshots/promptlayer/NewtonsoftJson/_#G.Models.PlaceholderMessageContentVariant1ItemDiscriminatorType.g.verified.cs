//HintName: G.Models.PlaceholderMessageContentVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PlaceholderMessageContentVariant1ItemDiscriminatorType
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
    public static class PlaceholderMessageContentVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaceholderMessageContentVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                PlaceholderMessageContentVariant1ItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.Code => "code",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.CodeExecutionResult => "code_execution_result",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.ImageUrl => "image_url",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.McpCall => "mcp_call",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.McpListTools => "mcp_list_tools",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.Media => "media",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.MediaVariable => "media_variable",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.OutputMedia => "output_media",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.ServerToolUse => "server_tool_use",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.ShellCall => "shell_call",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.Text => "text",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.Thinking => "thinking",
                PlaceholderMessageContentVariant1ItemDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaceholderMessageContentVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => PlaceholderMessageContentVariant1ItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => PlaceholderMessageContentVariant1ItemDiscriminatorType.ApplyPatchCallOutput,
                "bash_code_execution_tool_result" => PlaceholderMessageContentVariant1ItemDiscriminatorType.BashCodeExecutionToolResult,
                "code" => PlaceholderMessageContentVariant1ItemDiscriminatorType.Code,
                "code_execution_result" => PlaceholderMessageContentVariant1ItemDiscriminatorType.CodeExecutionResult,
                "image_url" => PlaceholderMessageContentVariant1ItemDiscriminatorType.ImageUrl,
                "mcp_approval_request" => PlaceholderMessageContentVariant1ItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => PlaceholderMessageContentVariant1ItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => PlaceholderMessageContentVariant1ItemDiscriminatorType.McpCall,
                "mcp_list_tools" => PlaceholderMessageContentVariant1ItemDiscriminatorType.McpListTools,
                "media" => PlaceholderMessageContentVariant1ItemDiscriminatorType.Media,
                "media_variable" => PlaceholderMessageContentVariant1ItemDiscriminatorType.MediaVariable,
                "output_media" => PlaceholderMessageContentVariant1ItemDiscriminatorType.OutputMedia,
                "server_tool_use" => PlaceholderMessageContentVariant1ItemDiscriminatorType.ServerToolUse,
                "shell_call" => PlaceholderMessageContentVariant1ItemDiscriminatorType.ShellCall,
                "shell_call_output" => PlaceholderMessageContentVariant1ItemDiscriminatorType.ShellCallOutput,
                "text" => PlaceholderMessageContentVariant1ItemDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => PlaceholderMessageContentVariant1ItemDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => PlaceholderMessageContentVariant1ItemDiscriminatorType.Thinking,
                "web_search_tool_result" => PlaceholderMessageContentVariant1ItemDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}