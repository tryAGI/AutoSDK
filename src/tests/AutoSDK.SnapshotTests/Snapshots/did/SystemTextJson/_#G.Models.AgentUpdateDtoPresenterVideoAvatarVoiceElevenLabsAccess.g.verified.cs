//HintName: G.Models.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess
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
    public static class AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Private => "private",
                AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}