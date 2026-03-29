//HintName: G.Models.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess
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
    public static class ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Premium => "premium",
                ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Private => "private",
                ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Premium,
                "private" => ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Private,
                "public" => ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}