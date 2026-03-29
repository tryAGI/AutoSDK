//HintName: G.Models.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess
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
    public static class GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Premium => "premium",
                GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Private => "private",
                GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Premium,
                "private" => GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Private,
                "public" => GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}