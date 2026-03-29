//HintName: G.Models.WebSearchRequestTopic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The search topic category. Use `news` for current events and news articles, or `general` for broader web search.<br/>
    /// Default Value: general
    /// </summary>
    public enum WebSearchRequestTopic
    {
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        News,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchRequestTopicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchRequestTopic value)
        {
            return value switch
            {
                WebSearchRequestTopic.General => "general",
                WebSearchRequestTopic.News => "news",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchRequestTopic? ToEnum(string value)
        {
            return value switch
            {
                "general" => WebSearchRequestTopic.General,
                "news" => WebSearchRequestTopic.News,
                _ => null,
            };
        }
    }
}