//HintName: G.Models.CodeInterpreterToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the code interpreter tool call. Always `code_interpreter_call`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeInterpreterToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter_call")]
        CodeInterpreterCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterToolCallType value)
        {
            return value switch
            {
                CodeInterpreterToolCallType.CodeInterpreterCall => "code_interpreter_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter_call" => CodeInterpreterToolCallType.CodeInterpreterCall,
                _ => null,
            };
        }
    }
}