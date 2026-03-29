//HintName: G.Models.BaseMessagesResultContentItemsOneOf7ContentOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf7ContentOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_execution_result")]
        CodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf7ContentOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf7ContentOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf7ContentOneOf1Type.CodeExecutionResult => "code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf7ContentOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_result" => BaseMessagesResultContentItemsOneOf7ContentOneOf1Type.CodeExecutionResult,
                _ => null,
            };
        }
    }
}