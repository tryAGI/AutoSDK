//HintName: G.Models.GetGroupResponseTranslationTranscriptionVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetGroupResponseTranslationTranscriptionVersion
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
    public static class GetGroupResponseTranslationTranscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGroupResponseTranslationTranscriptionVersion value)
        {
            return value switch
            {
                GetGroupResponseTranslationTranscriptionVersion.Edit => "edit",
                GetGroupResponseTranslationTranscriptionVersion.Original => "original",
                GetGroupResponseTranslationTranscriptionVersion.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGroupResponseTranslationTranscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "edit" => GetGroupResponseTranslationTranscriptionVersion.Edit,
                "original" => GetGroupResponseTranslationTranscriptionVersion.Original,
                "shortened" => GetGroupResponseTranslationTranscriptionVersion.Shortened,
                _ => null,
            };
        }
    }
}