//HintName: G.Models.ExclusionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExclusionType
    {
        /// <summary>
        /// 
        /// </summary>
        Regex,
        /// <summary>
        /// 
        /// </summary>
        WordList,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExclusionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExclusionType value)
        {
            return value switch
            {
                ExclusionType.Regex => "REGEX",
                ExclusionType.WordList => "WORD_LIST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExclusionType? ToEnum(string value)
        {
            return value switch
            {
                "REGEX" => ExclusionType.Regex,
                "WORD_LIST" => ExclusionType.WordList,
                _ => null,
            };
        }
    }
}