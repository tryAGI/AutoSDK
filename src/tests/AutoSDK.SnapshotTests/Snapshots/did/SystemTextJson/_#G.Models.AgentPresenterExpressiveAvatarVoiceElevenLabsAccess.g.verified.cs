//HintName: G.Models.AgentPresenterExpressiveAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum AgentPresenterExpressiveAvatarVoiceElevenLabsAccess
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
    public static class AgentPresenterExpressiveAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterExpressiveAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                AgentPresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                AgentPresenterExpressiveAvatarVoiceElevenLabsAccess.Premium => "premium",
                AgentPresenterExpressiveAvatarVoiceElevenLabsAccess.Private => "private",
                AgentPresenterExpressiveAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterExpressiveAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentPresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => AgentPresenterExpressiveAvatarVoiceElevenLabsAccess.Premium,
                "private" => AgentPresenterExpressiveAvatarVoiceElevenLabsAccess.Private,
                "public" => AgentPresenterExpressiveAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}