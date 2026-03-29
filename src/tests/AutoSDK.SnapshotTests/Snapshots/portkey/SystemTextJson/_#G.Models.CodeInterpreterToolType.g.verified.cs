//HintName: G.Models.CodeInterpreterToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the code interpreter tool. Always `code_interpreter`.
    /// </summary>
    public enum CodeInterpreterToolType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterToolType value)
        {
            return value switch
            {
                CodeInterpreterToolType.CodeInterpreter => "code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterToolType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => CodeInterpreterToolType.CodeInterpreter,
                _ => null,
            };
        }
    }
}