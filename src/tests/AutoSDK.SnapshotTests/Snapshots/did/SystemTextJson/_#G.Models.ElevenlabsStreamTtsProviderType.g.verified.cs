//HintName: G.Models.ElevenlabsStreamTtsProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ElevenlabsStreamTtsProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenlabsStreamTtsProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenlabsStreamTtsProviderType value)
        {
            return value switch
            {
                ElevenlabsStreamTtsProviderType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenlabsStreamTtsProviderType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ElevenlabsStreamTtsProviderType.Elevenlabs,
                _ => null,
            };
        }
    }
}