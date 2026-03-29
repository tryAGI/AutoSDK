//HintName: G.Models.FallbackElevenLabsVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum FallbackElevenLabsVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        x11labs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackElevenLabsVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackElevenLabsVoiceProvider value)
        {
            return value switch
            {
                FallbackElevenLabsVoiceProvider.x11labs => "11labs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackElevenLabsVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => FallbackElevenLabsVoiceProvider.x11labs,
                _ => null,
            };
        }
    }
}