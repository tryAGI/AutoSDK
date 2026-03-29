//HintName: G.Models.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash_code_execution_output")]
        BashCodeExecutionOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsType value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsType.BashCodeExecutionOutput => "bash_code_execution_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_output" => BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsType.BashCodeExecutionOutput,
                _ => null,
            };
        }
    }
}