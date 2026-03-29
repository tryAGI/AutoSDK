//HintName: G.Models.FallbackTavusVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum FallbackTavusVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Tavus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackTavusVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackTavusVoiceProvider value)
        {
            return value switch
            {
                FallbackTavusVoiceProvider.Tavus => "tavus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackTavusVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "tavus" => FallbackTavusVoiceProvider.Tavus,
                _ => null,
            };
        }
    }
}