//HintName: G.Models.BaseMessagesResultContentItemsOneOf4CallerOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf4CallerOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20250825,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf4CallerOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf4CallerOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf4CallerOneOf1Type.CodeExecution20250825 => "code_execution_20250825",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf4CallerOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => BaseMessagesResultContentItemsOneOf4CallerOneOf1Type.CodeExecution20250825,
                _ => null,
            };
        }
    }
}