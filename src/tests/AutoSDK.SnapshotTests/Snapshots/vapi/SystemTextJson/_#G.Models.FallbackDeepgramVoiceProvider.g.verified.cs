//HintName: G.Models.FallbackDeepgramVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum FallbackDeepgramVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackDeepgramVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackDeepgramVoiceProvider value)
        {
            return value switch
            {
                FallbackDeepgramVoiceProvider.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackDeepgramVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "deepgram" => FallbackDeepgramVoiceProvider.Deepgram,
                _ => null,
            };
        }
    }
}