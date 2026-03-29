//HintName: G.Models.CrawlUrlsRequestWebhookEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CrawlUrlsRequestWebhookEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Page,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CrawlUrlsRequestWebhookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CrawlUrlsRequestWebhookEvent value)
        {
            return value switch
            {
                CrawlUrlsRequestWebhookEvent.Completed => "completed",
                CrawlUrlsRequestWebhookEvent.Failed => "failed",
                CrawlUrlsRequestWebhookEvent.Page => "page",
                CrawlUrlsRequestWebhookEvent.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CrawlUrlsRequestWebhookEvent? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CrawlUrlsRequestWebhookEvent.Completed,
                "failed" => CrawlUrlsRequestWebhookEvent.Failed,
                "page" => CrawlUrlsRequestWebhookEvent.Page,
                "started" => CrawlUrlsRequestWebhookEvent.Started,
                _ => null,
            };
        }
    }
}