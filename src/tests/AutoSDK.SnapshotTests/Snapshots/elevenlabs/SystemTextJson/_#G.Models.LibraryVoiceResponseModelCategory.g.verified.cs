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
        Generated,
        /// <summary>
        /// 
        /// </summary>
        Cloned,
        /// <summary>
        /// 
        /// </summary>
        Premade,
        /// <summary>
        /// 
        /// </summary>
        Professional,
        /// <summary>
        /// 
        /// </summary>
        Famous,
        /// <summary>
        /// 
        /// </summary>
        HighQuality,
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
                LibraryVoiceResponseModelCategory.Generated => "generated",
                LibraryVoiceResponseModelCategory.Cloned => "cloned",
                LibraryVoiceResponseModelCategory.Premade => "premade",
                LibraryVoiceResponseModelCategory.Professional => "professional",
                LibraryVoiceResponseModelCategory.Famous => "famous",
                LibraryVoiceResponseModelCategory.HighQuality => "high_quality",
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
                "generated" => LibraryVoiceResponseModelCategory.Generated,
                "cloned" => LibraryVoiceResponseModelCategory.Cloned,
                "premade" => LibraryVoiceResponseModelCategory.Premade,
                "professional" => LibraryVoiceResponseModelCategory.Professional,
                "famous" => LibraryVoiceResponseModelCategory.Famous,
                "high_quality" => LibraryVoiceResponseModelCategory.HighQuality,
                _ => null,
            };
        }
    }
}