//HintName: G.Models.AutoChaptersResultErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoChaptersResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        AutoChaptersFailed,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedLanguage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoChaptersResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoChaptersResultErrorType value)
        {
            return value switch
            {
                AutoChaptersResultErrorType.AutoChaptersFailed => "auto_chapters_failed",
                AutoChaptersResultErrorType.UnsupportedLanguage => "unsupported_language",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoChaptersResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "auto_chapters_failed" => AutoChaptersResultErrorType.AutoChaptersFailed,
                "unsupported_language" => AutoChaptersResultErrorType.UnsupportedLanguage,
                _ => null,
            };
        }
    }
}