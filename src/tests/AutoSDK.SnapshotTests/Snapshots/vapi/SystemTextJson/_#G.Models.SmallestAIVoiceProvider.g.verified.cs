//HintName: G.Models.SmallestAIVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum SmallestAIVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        SmallestAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmallestAIVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmallestAIVoiceProvider value)
        {
            return value switch
            {
                SmallestAIVoiceProvider.SmallestAi => "smallest-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmallestAIVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "smallest-ai" => SmallestAIVoiceProvider.SmallestAi,
                _ => null,
            };
        }
    }
}