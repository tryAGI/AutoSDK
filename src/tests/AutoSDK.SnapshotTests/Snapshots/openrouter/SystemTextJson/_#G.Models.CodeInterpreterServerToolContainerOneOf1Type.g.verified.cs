//HintName: G.Models.CodeInterpreterServerToolContainerOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeInterpreterServerToolContainerOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterServerToolContainerOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterServerToolContainerOneOf1Type value)
        {
            return value switch
            {
                CodeInterpreterServerToolContainerOneOf1Type.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterServerToolContainerOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CodeInterpreterServerToolContainerOneOf1Type.Auto,
                _ => null,
            };
        }
    }
}