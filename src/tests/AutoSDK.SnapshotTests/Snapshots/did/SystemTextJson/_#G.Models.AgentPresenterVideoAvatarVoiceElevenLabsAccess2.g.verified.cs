//HintName: G.Models.AgentPresenterVideoAvatarVoiceElevenLabsAccess2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum AgentPresenterVideoAvatarVoiceElevenLabsAccess2
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
    public static class AgentPresenterVideoAvatarVoiceElevenLabsAccess2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterVideoAvatarVoiceElevenLabsAccess2 value)
        {
            return value switch
            {
                AgentPresenterVideoAvatarVoiceElevenLabsAccess2.ExternalPrivate => "external-private",
                AgentPresenterVideoAvatarVoiceElevenLabsAccess2.Premium => "premium",
                AgentPresenterVideoAvatarVoiceElevenLabsAccess2.Private => "private",
                AgentPresenterVideoAvatarVoiceElevenLabsAccess2.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterVideoAvatarVoiceElevenLabsAccess2? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentPresenterVideoAvatarVoiceElevenLabsAccess2.ExternalPrivate,
                "premium" => AgentPresenterVideoAvatarVoiceElevenLabsAccess2.Premium,
                "private" => AgentPresenterVideoAvatarVoiceElevenLabsAccess2.Private,
                "public" => AgentPresenterVideoAvatarVoiceElevenLabsAccess2.Public,
                _ => null,
            };
        }
    }
}