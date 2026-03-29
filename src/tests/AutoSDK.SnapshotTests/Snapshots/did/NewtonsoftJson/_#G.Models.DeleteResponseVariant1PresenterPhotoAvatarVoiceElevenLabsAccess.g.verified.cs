//HintName: G.Models.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess
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
    public static class DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Premium => "premium",
                DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Private => "private",
                DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Premium,
                "private" => DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Private,
                "public" => DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}