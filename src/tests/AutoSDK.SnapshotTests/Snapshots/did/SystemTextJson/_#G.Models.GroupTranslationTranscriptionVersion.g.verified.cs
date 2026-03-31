//HintName: G.Models.GroupTranslationTranscriptionVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GroupTranslationTranscriptionVersion
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
    public static class GroupTranslationTranscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupTranslationTranscriptionVersion value)
        {
            return value switch
            {
                GroupTranslationTranscriptionVersion.Edit => "edit",
                GroupTranslationTranscriptionVersion.Original => "original",
                GroupTranslationTranscriptionVersion.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupTranslationTranscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "edit" => GroupTranslationTranscriptionVersion.Edit,
                "original" => GroupTranslationTranscriptionVersion.Original,
                "shortened" => GroupTranslationTranscriptionVersion.Shortened,
                _ => null,
            };
        }
    }
}