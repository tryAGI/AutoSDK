//HintName: G.Models.StreamTextScriptProviderElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum StreamTextScriptProviderElevenLabsAccess
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
    public static class StreamTextScriptProviderElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamTextScriptProviderElevenLabsAccess value)
        {
            return value switch
            {
                StreamTextScriptProviderElevenLabsAccess.ExternalPrivate => "external-private",
                StreamTextScriptProviderElevenLabsAccess.Premium => "premium",
                StreamTextScriptProviderElevenLabsAccess.Private => "private",
                StreamTextScriptProviderElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamTextScriptProviderElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => StreamTextScriptProviderElevenLabsAccess.ExternalPrivate,
                "premium" => StreamTextScriptProviderElevenLabsAccess.Premium,
                "private" => StreamTextScriptProviderElevenLabsAccess.Private,
                "public" => StreamTextScriptProviderElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}