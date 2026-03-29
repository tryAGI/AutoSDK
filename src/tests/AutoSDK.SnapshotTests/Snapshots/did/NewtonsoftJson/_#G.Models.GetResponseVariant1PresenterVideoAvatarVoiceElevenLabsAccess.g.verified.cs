//HintName: G.Models.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess
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
    public static class GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess value)
        {
            return value switch
            {
                GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Premium => "premium",
                GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Private => "private",
                GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Premium,
                "private" => GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Private,
                "public" => GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}