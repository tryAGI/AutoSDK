//HintName: G.Models.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess
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
    public static class CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Premium => "premium",
                CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Private => "private",
                CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Premium,
                "private" => CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Private,
                "public" => CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}