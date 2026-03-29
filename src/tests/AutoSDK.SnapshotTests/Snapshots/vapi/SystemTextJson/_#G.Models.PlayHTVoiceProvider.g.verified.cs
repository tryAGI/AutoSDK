//HintName: G.Models.PlayHTVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum PlayHTVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Playht,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayHTVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayHTVoiceProvider value)
        {
            return value switch
            {
                PlayHTVoiceProvider.Playht => "playht",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayHTVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "playht" => PlayHTVoiceProvider.Playht,
                _ => null,
            };
        }
    }
}