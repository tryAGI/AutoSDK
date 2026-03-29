//HintName: G.Models.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess
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
    public static class AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess.Private => "private",
                AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}