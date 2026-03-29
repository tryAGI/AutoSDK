//HintName: G.Models.CloneVoiceRequestVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice provider to use for cloning.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CloneVoiceRequestVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cartesia")]
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fish_audio")]
        FishAudio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimax")]
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="platform")]
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