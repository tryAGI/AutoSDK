//HintName: G.Models.VoicesResponseItemVoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoicesResponseItemVoiceType
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
    public static class VoicesResponseItemVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesResponseItemVoiceType value)
        {
            return value switch
            {
                VoicesResponseItemVoiceType.Avatar => "Avatar",
                VoicesResponseItemVoiceType.CloneVoice => "CloneVoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesResponseItemVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "Avatar" => VoicesResponseItemVoiceType.Avatar,
                "CloneVoice" => VoicesResponseItemVoiceType.CloneVoice,
                _ => null,
            };
        }
    }
}