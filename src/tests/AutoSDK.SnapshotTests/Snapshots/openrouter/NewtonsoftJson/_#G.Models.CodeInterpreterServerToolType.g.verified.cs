//HintName: G.Models.CodeInterpreterServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeInterpreterServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter")]
        CodeInterpreter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterServerToolType value)
        {
            return value switch
            {
                CodeInterpreterServerToolType.CodeInterpreter => "code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => CodeInterpreterServerToolType.CodeInterpreter,
                _ => null,
            };
        }
    }
}