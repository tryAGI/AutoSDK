//HintName: G.Models.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess
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
    public static class GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Premium => "premium",
                GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Private => "private",
                GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Premium,
                "private" => GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Private,
                "public" => GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}