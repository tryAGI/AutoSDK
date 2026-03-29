//HintName: G.Models.CodeContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: code
    /// </summary>
    public enum CodeContentType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeContentType value)
        {
            return value switch
            {
                CodeContentType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeContentType? ToEnum(string value)
        {
            return value switch
            {
                "code" => CodeContentType.Code,
                _ => null,
            };
        }
    }
}