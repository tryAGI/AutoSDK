//HintName: G.Models.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess
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
    public static class UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Premium => "premium",
                UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Private => "private",
                UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Premium,
                "private" => UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Private,
                "public" => UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}