//HintName: G.Models.VoiceResponseProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the provider of voice.<br/>
    /// Example: elevenlabs
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceResponseProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cartesia")]
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepgram")]
        Deepgram,
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
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="platform")]
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceResponseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseProvider value)
        {
            return value switch
            {
                VoiceResponseProvider.Cartesia => "cartesia",
                VoiceResponseProvider.Deepgram => "deepgram",
                VoiceResponseProvider.Elevenlabs => "elevenlabs",
                VoiceResponseProvider.FishAudio => "fish_audio",
                VoiceResponseProvider.Minimax => "minimax",
                VoiceResponseProvider.Openai => "openai",
                VoiceResponseProvider.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => VoiceResponseProvider.Cartesia,
                "deepgram" => VoiceResponseProvider.Deepgram,
                "elevenlabs" => VoiceResponseProvider.Elevenlabs,
                "fish_audio" => VoiceResponseProvider.FishAudio,
                "minimax" => VoiceResponseProvider.Minimax,
                "openai" => VoiceResponseProvider.Openai,
                "platform" => VoiceResponseProvider.Platform,
                _ => null,
            };
        }
    }
}