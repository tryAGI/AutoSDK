//HintName: G.Models.BaseMessagesResultContentItemsOneOf1CallerOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf1CallerOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_execution_20250825")]
        CodeExecution20250825,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf1CallerOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf1CallerOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf1CallerOneOf1Type.CodeExecution20250825 => "code_execution_20250825",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf1CallerOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => BaseMessagesResultContentItemsOneOf1CallerOneOf1Type.CodeExecution20250825,
                _ => null,
            };
        }
    }
}