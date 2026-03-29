//HintName: G.Models.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsType
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
    public static class AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsType value)
        {
            return value switch
            {
                AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}