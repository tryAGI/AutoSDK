//HintName: G.Models.GetTranslationsResponseTranslationTranscriptionVersion2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTranslationsResponseTranslationTranscriptionVersion2
    {
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        Original,
        /// <summary>
        /// 
        /// </summary>
        Shortened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTranslationsResponseTranslationTranscriptionVersion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTranslationsResponseTranslationTranscriptionVersion2 value)
        {
            return value switch
            {
                GetTranslationsResponseTranslationTranscriptionVersion2.Edit => "edit",
                GetTranslationsResponseTranslationTranscriptionVersion2.Original => "original",
                GetTranslationsResponseTranslationTranscriptionVersion2.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTranslationsResponseTranslationTranscriptionVersion2? ToEnum(string value)
        {
            return value switch
            {
                "edit" => GetTranslationsResponseTranslationTranscriptionVersion2.Edit,
                "original" => GetTranslationsResponseTranslationTranscriptionVersion2.Original,
                "shortened" => GetTranslationsResponseTranslationTranscriptionVersion2.Shortened,
                _ => null,
            };
        }
    }
}