//HintName: G.Models.StreamScriptVariant1ProviderElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamScriptVariant1ProviderElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamScriptVariant1ProviderElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamScriptVariant1ProviderElevenLabsType value)
        {
            return value switch
            {
                StreamScriptVariant1ProviderElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamScriptVariant1ProviderElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => StreamScriptVariant1ProviderElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}