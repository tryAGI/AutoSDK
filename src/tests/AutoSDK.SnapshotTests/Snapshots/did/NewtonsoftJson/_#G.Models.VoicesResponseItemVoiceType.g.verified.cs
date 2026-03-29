//HintName: G.Models.VoicesResponseItemVoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoicesResponseItemVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Avatar")]
        Avatar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CloneVoice")]
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