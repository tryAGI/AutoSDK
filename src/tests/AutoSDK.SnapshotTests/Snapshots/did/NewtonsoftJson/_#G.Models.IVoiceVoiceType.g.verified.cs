//HintName: G.Models.IVoiceVoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IVoiceVoiceType
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
    public static class IVoiceVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IVoiceVoiceType value)
        {
            return value switch
            {
                IVoiceVoiceType.Avatar => "Avatar",
                IVoiceVoiceType.CloneVoice => "CloneVoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IVoiceVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "Avatar" => IVoiceVoiceType.Avatar,
                "CloneVoice" => IVoiceVoiceType.CloneVoice,
                _ => null,
            };
        }
    }
}