//HintName: G.Models.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external-private")]
        ExternalPrivate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premium")]
        Premium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Private => "private",
                AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}