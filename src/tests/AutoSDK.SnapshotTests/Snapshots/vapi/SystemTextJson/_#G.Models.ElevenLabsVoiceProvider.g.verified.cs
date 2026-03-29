//HintName: G.Models.ElevenLabsVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum ElevenLabsVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        x11labs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsVoiceProvider value)
        {
            return value switch
            {
                ElevenLabsVoiceProvider.x11labs => "11labs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => ElevenLabsVoiceProvider.x11labs,
                _ => null,
            };
        }
    }
}