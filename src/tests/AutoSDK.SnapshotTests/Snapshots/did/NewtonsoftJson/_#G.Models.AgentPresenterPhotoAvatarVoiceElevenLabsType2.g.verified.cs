//HintName: G.Models.AgentPresenterPhotoAvatarVoiceElevenLabsType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentPresenterPhotoAvatarVoiceElevenLabsType2
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
    public static class AgentPresenterPhotoAvatarVoiceElevenLabsType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterPhotoAvatarVoiceElevenLabsType2 value)
        {
            return value switch
            {
                AgentPresenterPhotoAvatarVoiceElevenLabsType2.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterPhotoAvatarVoiceElevenLabsType2? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => AgentPresenterPhotoAvatarVoiceElevenLabsType2.Elevenlabs,
                _ => null,
            };
        }
    }
}