//HintName: G.Models.VoiceCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premade")]
        Premade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cloned")]
        Cloned,
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
        [global::System.Runtime.Serialization.EnumMember(Value="famous")]
        Famous,
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
                VoiceCategory.Premade => "premade",
                VoiceCategory.Cloned => "cloned",
                VoiceCategory.Generated => "generated",
                VoiceCategory.Professional => "professional",
                VoiceCategory.Famous => "famous",
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
                "premade" => VoiceCategory.Premade,
                "cloned" => VoiceCategory.Cloned,
                "generated" => VoiceCategory.Generated,
                "professional" => VoiceCategory.Professional,
                "famous" => VoiceCategory.Famous,
                _ => null,
            };
        }
    }
}