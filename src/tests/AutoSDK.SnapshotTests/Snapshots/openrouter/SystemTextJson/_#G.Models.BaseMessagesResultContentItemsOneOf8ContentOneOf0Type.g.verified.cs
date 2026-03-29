//HintName: G.Models.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf8ContentOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf8ContentOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf8ContentOneOf0Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf8ContentOneOf0Type.BashCodeExecutionToolResultError => "bash_code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf8ContentOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result_error" => BaseMessagesResultContentItemsOneOf8ContentOneOf0Type.BashCodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}