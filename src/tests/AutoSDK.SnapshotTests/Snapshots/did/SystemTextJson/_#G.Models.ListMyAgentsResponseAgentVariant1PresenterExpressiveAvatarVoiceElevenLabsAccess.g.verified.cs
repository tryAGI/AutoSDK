//HintName: G.Models.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess
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
    public static class ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Premium => "premium",
                ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Private => "private",
                ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Premium,
                "private" => ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Private,
                "public" => ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}