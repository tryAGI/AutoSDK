//HintName: G.Models.VoiceSharingResponseModelCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
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
        [global::System.Runtime.Serialization.EnumMember(Value="professional")]
        Professional,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high_quality")]
        HighQuality,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="famous")]
        Famous,
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
                VoiceSharingResponseModelCategory.Professional => "professional",
                VoiceSharingResponseModelCategory.HighQuality => "high_quality",
                VoiceSharingResponseModelCategory.Famous => "famous",
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
                "professional" => VoiceSharingResponseModelCategory.Professional,
                "high_quality" => VoiceSharingResponseModelCategory.HighQuality,
                "famous" => VoiceSharingResponseModelCategory.Famous,
                _ => null,
            };
        }
    }
}