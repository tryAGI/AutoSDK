//HintName: G.Models.GetContentsResponseStatuseErrorTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specific error type<br/>
    /// Example: CRAWL_NOT_FOUND
    /// </summary>
    public enum GetContentsResponseStatuseErrorTag
    {
        /// <summary>
        /// 
        /// </summary>
        CrawlLivecrawlTimeout,
        /// <summary>
        /// 
        /// </summary>
        CrawlNotFound,
        /// <summary>
        /// 
        /// </summary>
        CrawlTimeout,
        /// <summary>
        /// 
        /// </summary>
        CrawlUnknownError,
        /// <summary>
        /// 
        /// </summary>
        SourceNotAvailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContentsResponseStatuseErrorTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContentsResponseStatuseErrorTag value)
        {
            return value switch
            {
                GetContentsResponseStatuseErrorTag.CrawlLivecrawlTimeout => "CRAWL_LIVECRAWL_TIMEOUT",
                GetContentsResponseStatuseErrorTag.CrawlNotFound => "CRAWL_NOT_FOUND",
                GetContentsResponseStatuseErrorTag.CrawlTimeout => "CRAWL_TIMEOUT",
                GetContentsResponseStatuseErrorTag.CrawlUnknownError => "CRAWL_UNKNOWN_ERROR",
                GetContentsResponseStatuseErrorTag.SourceNotAvailable => "SOURCE_NOT_AVAILABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContentsResponseStatuseErrorTag? ToEnum(string value)
        {
            return value switch
            {
                "CRAWL_LIVECRAWL_TIMEOUT" => GetContentsResponseStatuseErrorTag.CrawlLivecrawlTimeout,
                "CRAWL_NOT_FOUND" => GetContentsResponseStatuseErrorTag.CrawlNotFound,
                "CRAWL_TIMEOUT" => GetContentsResponseStatuseErrorTag.CrawlTimeout,
                "CRAWL_UNKNOWN_ERROR" => GetContentsResponseStatuseErrorTag.CrawlUnknownError,
                "SOURCE_NOT_AVAILABLE" => GetContentsResponseStatuseErrorTag.SourceNotAvailable,
                _ => null,
            };
        }
    }
}