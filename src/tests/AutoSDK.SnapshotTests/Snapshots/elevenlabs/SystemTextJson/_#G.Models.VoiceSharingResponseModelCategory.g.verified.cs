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
    public static class VoiceSharingResponseModelCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSharingResponseModelCategory value)
        {
            return value switch
            {
                VoiceSharingResponseModelCategory.Generated => "generated",
                VoiceSharingResponseModelCategory.Cloned => "cloned",
                VoiceSharingResponseModelCategory.Premade => "premade",
                VoiceSharingResponseModelCategory.Professional => "professional",
                VoiceSharingResponseModelCategory.Famous => "famous",
                VoiceSharingResponseModelCategory.HighQuality => "high_quality",
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
                "generated" => VoiceSharingResponseModelCategory.Generated,
                "cloned" => VoiceSharingResponseModelCategory.Cloned,
                "premade" => VoiceSharingResponseModelCategory.Premade,
                "professional" => VoiceSharingResponseModelCategory.Professional,
                "famous" => VoiceSharingResponseModelCategory.Famous,
                "high_quality" => VoiceSharingResponseModelCategory.HighQuality,
                _ => null,
            };
        }
    }
}