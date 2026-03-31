//HintName: G.Models.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess
    {
        /// <summary>
        /// 
        /// </summary>
        ExternalPrivate,
        /// <summary>
        /// 
        /// </summary>
        Premium,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Premium => "premium",
                CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Private => "private",
                CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Premium,
                "private" => CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Private,
                "public" => CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}