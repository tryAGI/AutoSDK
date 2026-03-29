//HintName: G.Models.PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess
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
    public static class PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess.Premium => "premium",
                PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess.Private => "private",
                PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess.Premium,
                "private" => PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess.Private,
                "public" => PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}