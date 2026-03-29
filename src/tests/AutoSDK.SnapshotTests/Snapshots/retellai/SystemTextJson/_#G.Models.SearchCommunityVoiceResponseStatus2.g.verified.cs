//HintName: G.Models.SearchCommunityVoiceResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchCommunityVoiceResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchCommunityVoiceResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCommunityVoiceResponseStatus2 value)
        {
            return value switch
            {
                SearchCommunityVoiceResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCommunityVoiceResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => SearchCommunityVoiceResponseStatus2.Error,
                _ => null,
            };
        }
    }
}