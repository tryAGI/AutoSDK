//HintName: G.Models.CreateTranslationResponseDtoTranslationTranscriptionVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTranslationResponseDtoTranslationTranscriptionVersion
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
    public static class CreateTranslationResponseDtoTranslationTranscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranslationResponseDtoTranslationTranscriptionVersion value)
        {
            return value switch
            {
                CreateTranslationResponseDtoTranslationTranscriptionVersion.Edit => "edit",
                CreateTranslationResponseDtoTranslationTranscriptionVersion.Original => "original",
                CreateTranslationResponseDtoTranslationTranscriptionVersion.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranslationResponseDtoTranslationTranscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "edit" => CreateTranslationResponseDtoTranslationTranscriptionVersion.Edit,
                "original" => CreateTranslationResponseDtoTranslationTranscriptionVersion.Original,
                "shortened" => CreateTranslationResponseDtoTranslationTranscriptionVersion.Shortened,
                _ => null,
            };
        }
    }
}