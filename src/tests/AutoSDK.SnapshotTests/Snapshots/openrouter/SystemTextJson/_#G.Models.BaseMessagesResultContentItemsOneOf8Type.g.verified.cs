//HintName: G.Models.BaseMessagesResultContentItemsOneOf8Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf8Type
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf8Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf8Type.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf8Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result" => BaseMessagesResultContentItemsOneOf8Type.BashCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}