//HintName: G.Models.AgentPresenterVideoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum AgentPresenterVideoAvatarVoiceElevenLabsAccess
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
    public static class AgentPresenterVideoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterVideoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentPresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentPresenterVideoAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentPresenterVideoAvatarVoiceElevenLabsAccess.Private => "private",
                AgentPresenterVideoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterVideoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentPresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentPresenterVideoAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentPresenterVideoAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentPresenterVideoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}