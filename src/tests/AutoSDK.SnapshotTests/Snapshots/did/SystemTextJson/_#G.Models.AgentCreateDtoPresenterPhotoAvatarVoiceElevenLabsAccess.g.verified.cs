//HintName: G.Models.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess
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
    public static class AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Private => "private",
                AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}