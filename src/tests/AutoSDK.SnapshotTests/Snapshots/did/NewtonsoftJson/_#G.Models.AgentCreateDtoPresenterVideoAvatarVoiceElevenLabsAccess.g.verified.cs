//HintName: G.Models.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess
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
    public static class AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Private => "private",
                AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}