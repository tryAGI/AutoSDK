//HintName: G.Models.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_execution_output")]
        CodeExecutionOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsType value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsType.CodeExecutionOutput => "code_execution_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_output" => BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsType.CodeExecutionOutput,
                _ => null,
            };
        }
    }
}