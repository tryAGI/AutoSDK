//HintName: G.Models.AgentPresenterPhotoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum AgentPresenterPhotoAvatarVoiceElevenLabsAccess
    {
        /// <summary>
        /// 
        /// </summary>
        ExternalPrivate,
        /// <summary>
        /// 
        /// </summary>
        Premium,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPresenterPhotoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterPhotoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentPresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentPresenterPhotoAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentPresenterPhotoAvatarVoiceElevenLabsAccess.Private => "private",
                AgentPresenterPhotoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterPhotoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentPresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentPresenterPhotoAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentPresenterPhotoAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentPresenterPhotoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}