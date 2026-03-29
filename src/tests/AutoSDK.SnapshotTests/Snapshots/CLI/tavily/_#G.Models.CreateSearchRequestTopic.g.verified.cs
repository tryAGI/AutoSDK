//HintName: G.Models.CreateSearchRequestTopic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of the search.`news` is useful for retrieving real-time updates, particularly about politics, sports, and major current events covered by mainstream media sources. `general` is for broader, more general-purpose searches that may include a wide range of sources.<br/>
    /// Default Value: general
    /// </summary>
    public enum CreateSearchRequestTopic
    {
        /// <summary>
        /// 
        /// </summary>
        Finance,
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
    public static class CreateSearchRequestTopicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSearchRequestTopic value)
        {
            return value switch
            {
                CreateSearchRequestTopic.Finance => "finance",
                CreateSearchRequestTopic.General => "general",
                CreateSearchRequestTopic.News => "news",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSearchRequestTopic? ToEnum(string value)
        {
            return value switch
            {
                "finance" => CreateSearchRequestTopic.Finance,
                "general" => CreateSearchRequestTopic.General,
                "news" => CreateSearchRequestTopic.News,
                _ => null,
            };
        }
    }
}