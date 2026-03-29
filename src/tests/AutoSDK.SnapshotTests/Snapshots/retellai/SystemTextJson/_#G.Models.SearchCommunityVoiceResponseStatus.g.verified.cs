//HintName: G.Models.SearchCommunityVoiceResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchCommunityVoiceResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchCommunityVoiceResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCommunityVoiceResponseStatus value)
        {
            return value switch
            {
                SearchCommunityVoiceResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCommunityVoiceResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => SearchCommunityVoiceResponseStatus.Error,
                _ => null,
            };
        }
    }
}