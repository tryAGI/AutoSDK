//HintName: G.Models.BaseMessagesResultContentItemsOneOf7ContentOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf7ContentOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf7ContentOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf7ContentOneOf0Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf7ContentOneOf0Type.CodeExecutionToolResultError => "code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf7ContentOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_tool_result_error" => BaseMessagesResultContentItemsOneOf7ContentOneOf0Type.CodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}