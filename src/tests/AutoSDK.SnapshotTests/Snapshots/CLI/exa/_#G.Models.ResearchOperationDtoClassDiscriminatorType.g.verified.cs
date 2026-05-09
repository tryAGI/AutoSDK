//HintName: G.Models.ResearchOperationDtoClassDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchOperationDtoClassDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Crawl,
        /// <summary>
        /// 
        /// </summary>
        Search,
        /// <summary>
        /// 
        /// </summary>
        Think,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchOperationDtoClassDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchOperationDtoClassDiscriminatorType value)
        {
            return value switch
            {
                ResearchOperationDtoClassDiscriminatorType.Crawl => "crawl",
                ResearchOperationDtoClassDiscriminatorType.Search => "search",
                ResearchOperationDtoClassDiscriminatorType.Think => "think",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchOperationDtoClassDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => ResearchOperationDtoClassDiscriminatorType.Crawl,
                "search" => ResearchOperationDtoClassDiscriminatorType.Search,
                "think" => ResearchOperationDtoClassDiscriminatorType.Think,
                _ => null,
            };
        }
    }
}