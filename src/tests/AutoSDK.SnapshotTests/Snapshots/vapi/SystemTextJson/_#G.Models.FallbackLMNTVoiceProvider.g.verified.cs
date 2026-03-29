//HintName: G.Models.FallbackLMNTVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum FallbackLMNTVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackLMNTVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackLMNTVoiceProvider value)
        {
            return value switch
            {
                FallbackLMNTVoiceProvider.Lmnt => "lmnt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackLMNTVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "lmnt" => FallbackLMNTVoiceProvider.Lmnt,
                _ => null,
            };
        }
    }
}