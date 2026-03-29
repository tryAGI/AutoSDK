//HintName: G.Models.AgentPresenterPhotoAvatarVoiceElevenLabsAccess2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentPresenterPhotoAvatarVoiceElevenLabsAccess2
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
    public static class AgentPresenterPhotoAvatarVoiceElevenLabsAccess2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterPhotoAvatarVoiceElevenLabsAccess2 value)
        {
            return value switch
            {
                AgentPresenterPhotoAvatarVoiceElevenLabsAccess2.ExternalPrivate => "external-private",
                AgentPresenterPhotoAvatarVoiceElevenLabsAccess2.Premium => "premium",
                AgentPresenterPhotoAvatarVoiceElevenLabsAccess2.Private => "private",
                AgentPresenterPhotoAvatarVoiceElevenLabsAccess2.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterPhotoAvatarVoiceElevenLabsAccess2? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentPresenterPhotoAvatarVoiceElevenLabsAccess2.ExternalPrivate,
                "premium" => AgentPresenterPhotoAvatarVoiceElevenLabsAccess2.Premium,
                "private" => AgentPresenterPhotoAvatarVoiceElevenLabsAccess2.Private,
                "public" => AgentPresenterPhotoAvatarVoiceElevenLabsAccess2.Public,
                _ => null,
            };
        }
    }
}