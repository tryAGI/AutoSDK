//HintName: G.Models.PartialAgentPresenterVideoAvatarVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialAgentPresenterVideoAvatarVoiceElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialAgentPresenterVideoAvatarVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialAgentPresenterVideoAvatarVoiceElevenLabsType value)
        {
            return value switch
            {
                PartialAgentPresenterVideoAvatarVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialAgentPresenterVideoAvatarVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => PartialAgentPresenterVideoAvatarVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}