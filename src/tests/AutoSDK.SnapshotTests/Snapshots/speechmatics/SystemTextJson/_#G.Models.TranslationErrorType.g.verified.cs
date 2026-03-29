//HintName: G.Models.TranslationErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranslationErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        TranslationFailed,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedTranslationPair,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationErrorType value)
        {
            return value switch
            {
                TranslationErrorType.TranslationFailed => "translation_failed",
                TranslationErrorType.UnsupportedTranslationPair => "unsupported_translation_pair",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationErrorType? ToEnum(string value)
        {
            return value switch
            {
                "translation_failed" => TranslationErrorType.TranslationFailed,
                "unsupported_translation_pair" => TranslationErrorType.UnsupportedTranslationPair,
                _ => null,
            };
        }
    }
}