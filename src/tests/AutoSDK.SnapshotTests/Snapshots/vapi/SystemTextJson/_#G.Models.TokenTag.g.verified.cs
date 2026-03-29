//HintName: G.Models.TokenTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the tag for the token. It represents its scope.
    /// </summary>
    public enum TokenTag
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenTag value)
        {
            return value switch
            {
                TokenTag.Private => "private",
                TokenTag.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenTag? ToEnum(string value)
        {
            return value switch
            {
                "private" => TokenTag.Private,
                "public" => TokenTag.Public,
                _ => null,
            };
        }
    }
}