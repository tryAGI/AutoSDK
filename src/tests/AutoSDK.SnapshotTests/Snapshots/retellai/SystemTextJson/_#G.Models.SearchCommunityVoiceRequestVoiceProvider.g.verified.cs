//HintName: G.Models.SearchCommunityVoiceRequestVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice provider to search.
    /// </summary>
    public enum SearchCommunityVoiceRequestVoiceProvider
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchCommunityVoiceRequestVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCommunityVoiceRequestVoiceProvider value)
        {
            return value switch
            {
                SearchCommunityVoiceRequestVoiceProvider.Cartesia => "cartesia",
                SearchCommunityVoiceRequestVoiceProvider.Elevenlabs => "elevenlabs",
                SearchCommunityVoiceRequestVoiceProvider.FishAudio => "fish_audio",
                SearchCommunityVoiceRequestVoiceProvider.Minimax => "minimax",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCommunityVoiceRequestVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => SearchCommunityVoiceRequestVoiceProvider.Cartesia,
                "elevenlabs" => SearchCommunityVoiceRequestVoiceProvider.Elevenlabs,
                "fish_audio" => SearchCommunityVoiceRequestVoiceProvider.FishAudio,
                "minimax" => SearchCommunityVoiceRequestVoiceProvider.Minimax,
                _ => null,
            };
        }
    }
}