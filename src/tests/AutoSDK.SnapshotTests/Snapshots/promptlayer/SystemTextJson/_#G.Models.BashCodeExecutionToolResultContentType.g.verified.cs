//HintName: G.Models.BashCodeExecutionToolResultContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: bash_code_execution_tool_result
    /// </summary>
    public enum BashCodeExecutionToolResultContentType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashCodeExecutionToolResultContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashCodeExecutionToolResultContentType value)
        {
            return value switch
            {
                BashCodeExecutionToolResultContentType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashCodeExecutionToolResultContentType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result" => BashCodeExecutionToolResultContentType.BashCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}