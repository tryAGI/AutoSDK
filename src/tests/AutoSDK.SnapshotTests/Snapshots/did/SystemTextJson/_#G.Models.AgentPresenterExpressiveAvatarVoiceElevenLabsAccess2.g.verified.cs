//HintName: G.Models.AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2
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
    public static class AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2 value)
        {
            return value switch
            {
                AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2.ExternalPrivate => "external-private",
                AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2.Premium => "premium",
                AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2.Private => "private",
                AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2.ExternalPrivate,
                "premium" => AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2.Premium,
                "private" => AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2.Private,
                "public" => AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2.Public,
                _ => null,
            };
        }
    }
}