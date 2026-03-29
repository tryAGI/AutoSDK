//HintName: G.Models.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType.CodeExecutionOutput => "code_execution_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_output" => BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType.CodeExecutionOutput,
                _ => null,
            };
        }
    }
}