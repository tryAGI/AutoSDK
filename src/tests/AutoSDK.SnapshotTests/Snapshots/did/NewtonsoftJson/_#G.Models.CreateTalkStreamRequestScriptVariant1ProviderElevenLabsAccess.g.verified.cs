//HintName: G.Models.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess
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
    public static class CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess value)
        {
            return value switch
            {
                CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess.ExternalPrivate => "external-private",
                CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess.Premium => "premium",
                CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess.Private => "private",
                CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess.ExternalPrivate,
                "premium" => CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess.Premium,
                "private" => CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess.Private,
                "public" => CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}