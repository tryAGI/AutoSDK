//HintName: G.Models.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsType
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
    public static class AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsType value)
        {
            return value switch
            {
                AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}