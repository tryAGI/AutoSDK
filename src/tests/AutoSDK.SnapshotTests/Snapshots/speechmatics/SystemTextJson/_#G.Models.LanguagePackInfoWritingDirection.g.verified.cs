//HintName: G.Models.LanguagePackInfoWritingDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The direction that words in the language should be written and read in.
    /// </summary>
    public enum LanguagePackInfoWritingDirection
    {
        /// <summary>
        /// 
        /// </summary>
        LeftToRight,
        /// <summary>
        /// 
        /// </summary>
        RightToLeft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguagePackInfoWritingDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguagePackInfoWritingDirection value)
        {
            return value switch
            {
                LanguagePackInfoWritingDirection.LeftToRight => "left-to-right",
                LanguagePackInfoWritingDirection.RightToLeft => "right-to-left",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguagePackInfoWritingDirection? ToEnum(string value)
        {
            return value switch
            {
                "left-to-right" => LanguagePackInfoWritingDirection.LeftToRight,
                "right-to-left" => LanguagePackInfoWritingDirection.RightToLeft,
                _ => null,
            };
        }
    }
}