//HintName: G.Models.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess
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
    public static class AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Private => "private",
                AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}