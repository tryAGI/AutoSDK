//HintName: G.Models.CodeToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "code" for Code tool.
    /// </summary>
    public enum CodeToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeToolType value)
        {
            return value switch
            {
                CodeToolType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeToolType? ToEnum(string value)
        {
            return value switch
            {
                "code" => CodeToolType.Code,
                _ => null,
            };
        }
    }
}