//HintName: G.Models.VoiceSharingResponseModelCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of the voice.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceSharingResponseModelCategory
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