//HintName: G.Models.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess
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
    public static class AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Private => "private",
                AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}