//HintName: G.Models.CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2
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
    public static class CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2 value)
        {
            return value switch
            {
                CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2.ExternalPrivate => "external-private",
                CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2.Premium => "premium",
                CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2.Private => "private",
                CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2.ExternalPrivate,
                "premium" => CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2.Premium,
                "private" => CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2.Private,
                "public" => CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2.Public,
                _ => null,
            };
        }
    }
}