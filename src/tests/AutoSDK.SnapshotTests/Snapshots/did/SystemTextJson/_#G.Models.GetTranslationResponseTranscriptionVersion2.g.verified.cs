//HintName: G.Models.GetTranslationResponseTranscriptionVersion2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTranslationResponseTranscriptionVersion2
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
    public static class GetTranslationResponseTranscriptionVersion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTranslationResponseTranscriptionVersion2 value)
        {
            return value switch
            {
                GetTranslationResponseTranscriptionVersion2.Edit => "edit",
                GetTranslationResponseTranscriptionVersion2.Original => "original",
                GetTranslationResponseTranscriptionVersion2.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTranslationResponseTranscriptionVersion2? ToEnum(string value)
        {
            return value switch
            {
                "edit" => GetTranslationResponseTranscriptionVersion2.Edit,
                "original" => GetTranslationResponseTranscriptionVersion2.Original,
                "shortened" => GetTranslationResponseTranscriptionVersion2.Shortened,
                _ => null,
            };
        }
    }
}