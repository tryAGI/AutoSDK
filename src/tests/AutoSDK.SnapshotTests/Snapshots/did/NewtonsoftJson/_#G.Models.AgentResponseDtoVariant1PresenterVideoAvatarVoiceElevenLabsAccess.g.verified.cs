//HintName: G.Models.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess
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
    public static class AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Private => "private",
                AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}