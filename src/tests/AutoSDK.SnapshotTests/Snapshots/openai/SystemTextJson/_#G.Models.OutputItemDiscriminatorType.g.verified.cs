//HintName: G.Models.OutputItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemDiscriminatorType
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
        FunctionCall,
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
        McpApprovalRequest,
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
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemDiscriminatorType value)
        {
            return value switch
            {
                OutputItemDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                OutputItemDiscriminatorType.ComputerCall => "computer_call",
                OutputItemDiscriminatorType.FileSearchCall => "file_search_call",
                OutputItemDiscriminatorType.FunctionCall => "function_call",
                OutputItemDiscriminatorType.ImageGenerationCall => "image_generation_call",
                OutputItemDiscriminatorType.LocalShellCall => "local_shell_call",
                OutputItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                OutputItemDiscriminatorType.McpCall => "mcp_call",
                OutputItemDiscriminatorType.McpListTools => "mcp_list_tools",
                OutputItemDiscriminatorType.Message => "message",
                OutputItemDiscriminatorType.Reasoning => "reasoning",
                OutputItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter_call" => OutputItemDiscriminatorType.CodeInterpreterCall,
                "computer_call" => OutputItemDiscriminatorType.ComputerCall,
                "file_search_call" => OutputItemDiscriminatorType.FileSearchCall,
                "function_call" => OutputItemDiscriminatorType.FunctionCall,
                "image_generation_call" => OutputItemDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => OutputItemDiscriminatorType.LocalShellCall,
                "mcp_approval_request" => OutputItemDiscriminatorType.McpApprovalRequest,
                "mcp_call" => OutputItemDiscriminatorType.McpCall,
                "mcp_list_tools" => OutputItemDiscriminatorType.McpListTools,
                "message" => OutputItemDiscriminatorType.Message,
                "reasoning" => OutputItemDiscriminatorType.Reasoning,
                "web_search_call" => OutputItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}