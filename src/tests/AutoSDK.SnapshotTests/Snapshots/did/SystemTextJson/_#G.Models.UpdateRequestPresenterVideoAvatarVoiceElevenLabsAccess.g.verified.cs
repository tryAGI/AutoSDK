//HintName: G.Models.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess
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
    public static class UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess.Premium => "premium",
                UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess.Private => "private",
                UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess.Premium,
                "private" => UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess.Private,
                "public" => UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}