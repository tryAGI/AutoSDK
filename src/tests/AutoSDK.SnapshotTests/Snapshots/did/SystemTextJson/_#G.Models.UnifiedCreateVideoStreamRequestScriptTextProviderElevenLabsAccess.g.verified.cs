//HintName: G.Models.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess
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
    public static class UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess value)
        {
            return value switch
            {
                UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess.ExternalPrivate => "external-private",
                UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Premium => "premium",
                UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Private => "private",
                UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess.ExternalPrivate,
                "premium" => UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Premium,
                "private" => UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Private,
                "public" => UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}