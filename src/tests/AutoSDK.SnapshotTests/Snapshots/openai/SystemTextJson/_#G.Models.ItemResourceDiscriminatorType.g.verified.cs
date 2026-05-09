//HintName: G.Models.ItemResourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ItemResourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreterCall,
        /// <summary>
        /// 
        /// </summary>
        ComputerCall,
        /// <summary>
        /// 
        /// </summary>
        FileSearchCall,
        /// <summary>
        /// 
        /// </summary>
        ImageGenerationCall,
        /// <summary>
        /// 
        /// </summary>
        LocalShellCall,
        /// <summary>
        /// 
        /// </summary>
        LocalShellCallOutput,
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
        Message,
        /// <summary>
        /// 
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ItemResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemResourceDiscriminatorType value)
        {
            return value switch
            {
                ItemResourceDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                ItemResourceDiscriminatorType.ComputerCall => "computer_call",
                ItemResourceDiscriminatorType.FileSearchCall => "file_search_call",
                ItemResourceDiscriminatorType.ImageGenerationCall => "image_generation_call",
                ItemResourceDiscriminatorType.LocalShellCall => "local_shell_call",
                ItemResourceDiscriminatorType.LocalShellCallOutput => "local_shell_call_output",
                ItemResourceDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                ItemResourceDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                ItemResourceDiscriminatorType.McpCall => "mcp_call",
                ItemResourceDiscriminatorType.McpListTools => "mcp_list_tools",
                ItemResourceDiscriminatorType.Message => "message",
                ItemResourceDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter_call" => ItemResourceDiscriminatorType.CodeInterpreterCall,
                "computer_call" => ItemResourceDiscriminatorType.ComputerCall,
                "file_search_call" => ItemResourceDiscriminatorType.FileSearchCall,
                "image_generation_call" => ItemResourceDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => ItemResourceDiscriminatorType.LocalShellCall,
                "local_shell_call_output" => ItemResourceDiscriminatorType.LocalShellCallOutput,
                "mcp_approval_request" => ItemResourceDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => ItemResourceDiscriminatorType.McpApprovalResponse,
                "mcp_call" => ItemResourceDiscriminatorType.McpCall,
                "mcp_list_tools" => ItemResourceDiscriminatorType.McpListTools,
                "message" => ItemResourceDiscriminatorType.Message,
                "web_search_call" => ItemResourceDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}