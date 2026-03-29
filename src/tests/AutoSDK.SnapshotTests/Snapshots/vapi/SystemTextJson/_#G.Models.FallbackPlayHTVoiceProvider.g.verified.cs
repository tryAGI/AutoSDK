//HintName: G.Models.FallbackPlayHTVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum FallbackPlayHTVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Playht,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackPlayHTVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackPlayHTVoiceProvider value)
        {
            return value switch
            {
                FallbackPlayHTVoiceProvider.Playht => "playht",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackPlayHTVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "playht" => FallbackPlayHTVoiceProvider.Playht,
                _ => null,
            };
        }
    }
}