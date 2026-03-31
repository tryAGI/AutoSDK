//HintName: G.Models.ProvidersElevenlabs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProvidersElevenlabs
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProvidersElevenlabsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvidersElevenlabs value)
        {
            return value switch
            {
                ProvidersElevenlabs.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvidersElevenlabs? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ProvidersElevenlabs.Elevenlabs,
                _ => null,
            };
        }
    }
}