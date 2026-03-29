//HintName: G.Models.ChatWebSearchShorthandType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatWebSearchShorthandType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
        /// <summary>
        /// 
        /// </summary>
        WebSearch20250826,
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview,
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview20250311,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatWebSearchShorthandTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchShorthandType value)
        {
            return value switch
            {
                ChatWebSearchShorthandType.WebSearch => "web_search",
                ChatWebSearchShorthandType.WebSearch20250826 => "web_search_2025_08_26",
                ChatWebSearchShorthandType.WebSearchPreview => "web_search_preview",
                ChatWebSearchShorthandType.WebSearchPreview20250311 => "web_search_preview_2025_03_11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchShorthandType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => ChatWebSearchShorthandType.WebSearch,
                "web_search_2025_08_26" => ChatWebSearchShorthandType.WebSearch20250826,
                "web_search_preview" => ChatWebSearchShorthandType.WebSearchPreview,
                "web_search_preview_2025_03_11" => ChatWebSearchShorthandType.WebSearchPreview20250311,
                _ => null,
            };
        }
    }
}