//HintName: G.Models.PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess
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
    public static class PartialAgentPresenterVideoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess.Premium => "premium",
                PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess.Private => "private",
                PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess.Premium,
                "private" => PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess.Private,
                "public" => PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}