//HintName: G.Models.VoiceResponseModelCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of the voice.
    /// </summary>
    public enum VoiceResponseModelCategory
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
    public static class VoiceResponseModelCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseModelCategory value)
        {
            return value switch
            {
                VoiceResponseModelCategory.Cloned => "cloned",
                VoiceResponseModelCategory.Famous => "famous",
                VoiceResponseModelCategory.Generated => "generated",
                VoiceResponseModelCategory.HighQuality => "high_quality",
                VoiceResponseModelCategory.Premade => "premade",
                VoiceResponseModelCategory.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseModelCategory? ToEnum(string value)
        {
            return value switch
            {
                "cloned" => VoiceResponseModelCategory.Cloned,
                "famous" => VoiceResponseModelCategory.Famous,
                "generated" => VoiceResponseModelCategory.Generated,
                "high_quality" => VoiceResponseModelCategory.HighQuality,
                "premade" => VoiceResponseModelCategory.Premade,
                "professional" => VoiceResponseModelCategory.Professional,
                _ => null,
            };
        }
    }
}