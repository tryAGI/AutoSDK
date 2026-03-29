//HintName: G.Models.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess
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
    public static class CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess.Premium => "premium",
                CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess.Private => "private",
                CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess.Premium,
                "private" => CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess.Private,
                "public" => CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}