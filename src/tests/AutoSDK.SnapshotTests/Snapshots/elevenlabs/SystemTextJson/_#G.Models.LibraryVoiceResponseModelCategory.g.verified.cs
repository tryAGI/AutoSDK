//HintName: G.Models.LibraryVoiceResponseModelCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of the voice.
    /// </summary>
    public enum LibraryVoiceResponseModelCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Cloned,
        /// <summary>
        /// 
        /// </summary>
        Famous,
        /// <summary>
        /// 
        /// </summary>
        Generated,
        /// <summary>
        /// 
        /// </summary>
        HighQuality,
        /// <summary>
        /// 
        /// </summary>
        Premade,
        /// <summary>
        /// 
        /// </summary>
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LibraryVoiceResponseModelCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LibraryVoiceResponseModelCategory value)
        {
            return value switch
            {
                LibraryVoiceResponseModelCategory.Cloned => "cloned",
                LibraryVoiceResponseModelCategory.Famous => "famous",
                LibraryVoiceResponseModelCategory.Generated => "generated",
                LibraryVoiceResponseModelCategory.HighQuality => "high_quality",
                LibraryVoiceResponseModelCategory.Premade => "premade",
                LibraryVoiceResponseModelCategory.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LibraryVoiceResponseModelCategory? ToEnum(string value)
        {
            return value switch
            {
                "cloned" => LibraryVoiceResponseModelCategory.Cloned,
                "famous" => LibraryVoiceResponseModelCategory.Famous,
                "generated" => LibraryVoiceResponseModelCategory.Generated,
                "high_quality" => LibraryVoiceResponseModelCategory.HighQuality,
                "premade" => LibraryVoiceResponseModelCategory.Premade,
                "professional" => LibraryVoiceResponseModelCategory.Professional,
                _ => null,
            };
        }
    }
}