//HintName: G.Models.AddCommunityVoiceRequestVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice provider to add the voice from.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AddCommunityVoiceRequestVoiceProvider
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddCommunityVoiceRequestVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddCommunityVoiceRequestVoiceProvider value)
        {
            return value switch
            {
                AddCommunityVoiceRequestVoiceProvider.Cartesia => "cartesia",
                AddCommunityVoiceRequestVoiceProvider.Elevenlabs => "elevenlabs",
                AddCommunityVoiceRequestVoiceProvider.FishAudio => "fish_audio",
                AddCommunityVoiceRequestVoiceProvider.Minimax => "minimax",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddCommunityVoiceRequestVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => AddCommunityVoiceRequestVoiceProvider.Cartesia,
                "elevenlabs" => AddCommunityVoiceRequestVoiceProvider.Elevenlabs,
                "fish_audio" => AddCommunityVoiceRequestVoiceProvider.FishAudio,
                "minimax" => AddCommunityVoiceRequestVoiceProvider.Minimax,
                _ => null,
            };
        }
    }
}