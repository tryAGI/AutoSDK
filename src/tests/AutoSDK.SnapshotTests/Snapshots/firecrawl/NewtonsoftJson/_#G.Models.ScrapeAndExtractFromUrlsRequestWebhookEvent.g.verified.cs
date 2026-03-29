//HintName: G.Models.ScrapeAndExtractFromUrlsRequestWebhookEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScrapeAndExtractFromUrlsRequestWebhookEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page")]
        Page,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
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