//HintName: G.Models.VoiceSharingResponseModelCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of the voice.
    /// </summary>
    public enum VoiceSharingResponseModelCategory
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
    public static class VoiceSharingResponseModelCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSharingResponseModelCategory value)
        {
            return value switch
            {
                VoiceSharingResponseModelCategory.Cloned => "cloned",
                VoiceSharingResponseModelCategory.Famous => "famous",
                VoiceSharingResponseModelCategory.Generated => "generated",
                VoiceSharingResponseModelCategory.HighQuality => "high_quality",
                VoiceSharingResponseModelCategory.Premade => "premade",
                VoiceSharingResponseModelCategory.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSharingResponseModelCategory? ToEnum(string value)
        {
            return value switch
            {
                "cloned" => VoiceSharingResponseModelCategory.Cloned,
                "famous" => VoiceSharingResponseModelCategory.Famous,
                "generated" => VoiceSharingResponseModelCategory.Generated,
                "high_quality" => VoiceSharingResponseModelCategory.HighQuality,
                "premade" => VoiceSharingResponseModelCategory.Premade,
                "professional" => VoiceSharingResponseModelCategory.Professional,
                _ => null,
            };
        }
    }
}