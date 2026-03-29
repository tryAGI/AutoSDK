//HintName: G.Models.StreamScriptVariant1ProviderElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamScriptVariant1ProviderElevenLabsAccess
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
    public static class StreamScriptVariant1ProviderElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamScriptVariant1ProviderElevenLabsAccess value)
        {
            return value switch
            {
                StreamScriptVariant1ProviderElevenLabsAccess.ExternalPrivate => "external-private",
                StreamScriptVariant1ProviderElevenLabsAccess.Premium => "premium",
                StreamScriptVariant1ProviderElevenLabsAccess.Private => "private",
                StreamScriptVariant1ProviderElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamScriptVariant1ProviderElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => StreamScriptVariant1ProviderElevenLabsAccess.ExternalPrivate,
                "premium" => StreamScriptVariant1ProviderElevenLabsAccess.Premium,
                "private" => StreamScriptVariant1ProviderElevenLabsAccess.Private,
                "public" => StreamScriptVariant1ProviderElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}