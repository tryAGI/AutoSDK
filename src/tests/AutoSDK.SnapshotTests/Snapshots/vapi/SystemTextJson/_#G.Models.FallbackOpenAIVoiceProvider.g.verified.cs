//HintName: G.Models.FallbackOpenAIVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum FallbackOpenAIVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackOpenAIVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackOpenAIVoiceProvider value)
        {
            return value switch
            {
                FallbackOpenAIVoiceProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackOpenAIVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => FallbackOpenAIVoiceProvider.Openai,
                _ => null,
            };
        }
    }
}