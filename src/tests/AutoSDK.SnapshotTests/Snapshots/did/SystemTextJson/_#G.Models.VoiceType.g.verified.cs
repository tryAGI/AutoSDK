//HintName: G.Models.VoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Avatar,
        /// <summary>
        /// 
        /// </summary>
        CloneVoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceType value)
        {
            return value switch
            {
                VoiceType.Avatar => "Avatar",
                VoiceType.CloneVoice => "CloneVoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceType? ToEnum(string value)
        {
            return value switch
            {
                "Avatar" => VoiceType.Avatar,
                "CloneVoice" => VoiceType.CloneVoice,
                _ => null,
            };
        }
    }
}