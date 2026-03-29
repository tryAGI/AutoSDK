//HintName: G.Models.ScrapeAndExtractFromUrlsRequestWebhookEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScrapeAndExtractFromUrlsRequestWebhookEvent
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
    public static class ScrapeAndExtractFromUrlsRequestWebhookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeAndExtractFromUrlsRequestWebhookEvent value)
        {
            return value switch
            {
                ScrapeAndExtractFromUrlsRequestWebhookEvent.Completed => "completed",
                ScrapeAndExtractFromUrlsRequestWebhookEvent.Failed => "failed",
                ScrapeAndExtractFromUrlsRequestWebhookEvent.Page => "page",
                ScrapeAndExtractFromUrlsRequestWebhookEvent.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeAndExtractFromUrlsRequestWebhookEvent? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ScrapeAndExtractFromUrlsRequestWebhookEvent.Completed,
                "failed" => ScrapeAndExtractFromUrlsRequestWebhookEvent.Failed,
                "page" => ScrapeAndExtractFromUrlsRequestWebhookEvent.Page,
                "started" => ScrapeAndExtractFromUrlsRequestWebhookEvent.Started,
                _ => null,
            };
        }
    }
}