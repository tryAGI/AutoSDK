//HintName: G.Models.BaseMessagesResultContentItemsOneOf5CallerOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf5CallerOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_execution_20260120")]
        CodeExecution20260120,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf5CallerOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf5CallerOneOf2Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf5CallerOneOf2Type.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf5CallerOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20260120" => BaseMessagesResultContentItemsOneOf5CallerOneOf2Type.CodeExecution20260120,
                _ => null,
            };
        }
    }
}