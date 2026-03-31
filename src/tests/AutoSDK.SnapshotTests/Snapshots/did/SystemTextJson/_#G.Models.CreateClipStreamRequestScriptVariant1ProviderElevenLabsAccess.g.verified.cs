//HintName: G.Models.CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess
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
    public static class CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess value)
        {
            return value switch
            {
                CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess.ExternalPrivate => "external-private",
                CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess.Premium => "premium",
                CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess.Private => "private",
                CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess.ExternalPrivate,
                "premium" => CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess.Premium,
                "private" => CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess.Private,
                "public" => CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}