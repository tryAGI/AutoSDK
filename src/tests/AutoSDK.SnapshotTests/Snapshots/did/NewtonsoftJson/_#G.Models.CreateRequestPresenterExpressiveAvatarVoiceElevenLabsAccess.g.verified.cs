//HintName: G.Models.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess
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
    public static class CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess.Premium => "premium",
                CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess.Private => "private",
                CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess.Premium,
                "private" => CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess.Private,
                "public" => CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}