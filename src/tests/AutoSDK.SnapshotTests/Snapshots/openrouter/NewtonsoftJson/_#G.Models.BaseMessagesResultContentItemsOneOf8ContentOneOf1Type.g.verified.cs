//HintName: G.Models.BaseMessagesResultContentItemsOneOf8ContentOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf8ContentOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash_code_execution_result")]
        BashCodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf8ContentOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf8ContentOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf8ContentOneOf1Type.BashCodeExecutionResult => "bash_code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf8ContentOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_result" => BaseMessagesResultContentItemsOneOf8ContentOneOf1Type.BashCodeExecutionResult,
                _ => null,
            };
        }
    }
}