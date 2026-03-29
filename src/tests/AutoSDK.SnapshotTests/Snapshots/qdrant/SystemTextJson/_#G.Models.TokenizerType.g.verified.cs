//HintName: G.Models.TokenizerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TokenizerType
    {
        /// <summary>
        /// 
        /// </summary>
        Multilingual,
        /// <summary>
        /// 
        /// </summary>
        Prefix,
        /// <summary>
        /// 
        /// </summary>
        Whitespace,
        /// <summary>
        /// 
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenizerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenizerType value)
        {
            return value switch
            {
                TokenizerType.Multilingual => "multilingual",
                TokenizerType.Prefix => "prefix",
                TokenizerType.Whitespace => "whitespace",
                TokenizerType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenizerType? ToEnum(string value)
        {
            return value switch
            {
                "multilingual" => TokenizerType.Multilingual,
                "prefix" => TokenizerType.Prefix,
                "whitespace" => TokenizerType.Whitespace,
                "word" => TokenizerType.Word,
                _ => null,
            };
        }
    }
}