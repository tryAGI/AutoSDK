//HintName: G.Models.CloneVoiceRequestVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice provider to use for cloning.
    /// </summary>
    public enum CloneVoiceRequestVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        FishAudio,
        /// <summary>
        /// 
        /// </summary>
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CloneVoiceRequestVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloneVoiceRequestVoiceProvider value)
        {
            return value switch
            {
                CloneVoiceRequestVoiceProvider.Cartesia => "cartesia",
                CloneVoiceRequestVoiceProvider.Elevenlabs => "elevenlabs",
                CloneVoiceRequestVoiceProvider.FishAudio => "fish_audio",
                CloneVoiceRequestVoiceProvider.Minimax => "minimax",
                CloneVoiceRequestVoiceProvider.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloneVoiceRequestVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => CloneVoiceRequestVoiceProvider.Cartesia,
                "elevenlabs" => CloneVoiceRequestVoiceProvider.Elevenlabs,
                "fish_audio" => CloneVoiceRequestVoiceProvider.FishAudio,
                "minimax" => CloneVoiceRequestVoiceProvider.Minimax,
                "platform" => CloneVoiceRequestVoiceProvider.Platform,
                _ => null,
            };
        }
    }
}