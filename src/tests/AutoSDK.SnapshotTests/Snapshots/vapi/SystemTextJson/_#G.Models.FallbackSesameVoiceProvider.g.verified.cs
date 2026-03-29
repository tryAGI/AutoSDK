//HintName: G.Models.FallbackSesameVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum FallbackSesameVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Sesame,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackSesameVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSesameVoiceProvider value)
        {
            return value switch
            {
                FallbackSesameVoiceProvider.Sesame => "sesame",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSesameVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "sesame" => FallbackSesameVoiceProvider.Sesame,
                _ => null,
            };
        }
    }
}