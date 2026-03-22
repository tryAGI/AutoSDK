//HintName: G.Models.VoiceCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceCategory
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
        Premade,
        /// <summary>
        /// 
        /// </summary>
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceCategory value)
        {
            return value switch
            {
                VoiceCategory.Cloned => "cloned",
                VoiceCategory.Famous => "famous",
                VoiceCategory.Generated => "generated",
                VoiceCategory.Premade => "premade",
                VoiceCategory.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceCategory? ToEnum(string value)
        {
            return value switch
            {
                "cloned" => VoiceCategory.Cloned,
                "famous" => VoiceCategory.Famous,
                "generated" => VoiceCategory.Generated,
                "premade" => VoiceCategory.Premade,
                "professional" => VoiceCategory.Professional,
                _ => null,
            };
        }
    }
}