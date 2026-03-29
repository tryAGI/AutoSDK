//HintName: G.Models.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess
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
    public static class UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Premium => "premium",
                UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Private => "private",
                UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Premium,
                "private" => UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Private,
                "public" => UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}