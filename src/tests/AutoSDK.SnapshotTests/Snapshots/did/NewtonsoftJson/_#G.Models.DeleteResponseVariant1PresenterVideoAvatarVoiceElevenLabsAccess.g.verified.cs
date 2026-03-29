//HintName: G.Models.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess
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
    public static class DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Premium => "premium",
                DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Private => "private",
                DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Premium,
                "private" => DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Private,
                "public" => DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}