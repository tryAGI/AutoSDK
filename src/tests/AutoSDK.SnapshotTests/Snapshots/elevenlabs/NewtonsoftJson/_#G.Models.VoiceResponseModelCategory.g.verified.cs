//HintName: G.Models.VoiceResponseModelCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceResponseModelCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generated")]
        Generated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cloned")]
        Cloned,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premade")]
        Premade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="professional")]
        Professional,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="famous")]
        Famous,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high_quality")]
        HighQuality,
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
                VoiceResponseModelCategory.Generated => "generated",
                VoiceResponseModelCategory.Cloned => "cloned",
                VoiceResponseModelCategory.Premade => "premade",
                VoiceResponseModelCategory.Professional => "professional",
                VoiceResponseModelCategory.Famous => "famous",
                VoiceResponseModelCategory.HighQuality => "high_quality",
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
                "generated" => VoiceResponseModelCategory.Generated,
                "cloned" => VoiceResponseModelCategory.Cloned,
                "premade" => VoiceResponseModelCategory.Premade,
                "professional" => VoiceResponseModelCategory.Professional,
                "famous" => VoiceResponseModelCategory.Famous,
                "high_quality" => VoiceResponseModelCategory.HighQuality,
                _ => null,
            };
        }
    }
}