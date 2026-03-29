//HintName: G.Models.WebhookConfigurationWebhookEventsVariant1Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookConfigurationWebhookEventsVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        ClassifyCancelled,
        /// <summary>
        /// 
        /// </summary>
        ClassifyError,
        /// <summary>
        /// 
        /// </summary>
        ClassifyPartialSuccess,
        /// <summary>
        /// 
        /// </summary>
        ClassifyPending,
        /// <summary>
        /// 
        /// </summary>
        ClassifySuccess,
        /// <summary>
        /// 
        /// </summary>
        ExtractCancelled,
        /// <summary>
        /// 
        /// </summary>
        ExtractError,
        /// <summary>
        /// 
        /// </summary>
        ExtractPartialSuccess,
        /// <summary>
        /// 
        /// </summary>
        ExtractPending,
        /// <summary>
        /// 
        /// </summary>
        ExtractSuccess,
        /// <summary>
        /// 
        /// </summary>
        ParseCancelled,
        /// <summary>
        /// 
        /// </summary>
        ParseError,
        /// <summary>
        /// 
        /// </summary>
        ParsePartialSuccess,
        /// <summary>
        /// 
        /// </summary>
        ParsePending,
        /// <summary>
        /// 
        /// </summary>
        ParseRunning,
        /// <summary>
        /// 
        /// </summary>
        ParseSuccess,
        /// <summary>
        /// 
        /// </summary>
        UnmappedEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookConfigurationWebhookEventsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigurationWebhookEventsVariant1Item value)
        {
            return value switch
            {
                WebhookConfigurationWebhookEventsVariant1Item.ClassifyCancelled => "classify.cancelled",
                WebhookConfigurationWebhookEventsVariant1Item.ClassifyError => "classify.error",
                WebhookConfigurationWebhookEventsVariant1Item.ClassifyPartialSuccess => "classify.partial_success",
                WebhookConfigurationWebhookEventsVariant1Item.ClassifyPending => "classify.pending",
                WebhookConfigurationWebhookEventsVariant1Item.ClassifySuccess => "classify.success",
                WebhookConfigurationWebhookEventsVariant1Item.ExtractCancelled => "extract.cancelled",
                WebhookConfigurationWebhookEventsVariant1Item.ExtractError => "extract.error",
                WebhookConfigurationWebhookEventsVariant1Item.ExtractPartialSuccess => "extract.partial_success",
                WebhookConfigurationWebhookEventsVariant1Item.ExtractPending => "extract.pending",
                WebhookConfigurationWebhookEventsVariant1Item.ExtractSuccess => "extract.success",
                WebhookConfigurationWebhookEventsVariant1Item.ParseCancelled => "parse.cancelled",
                WebhookConfigurationWebhookEventsVariant1Item.ParseError => "parse.error",
                WebhookConfigurationWebhookEventsVariant1Item.ParsePartialSuccess => "parse.partial_success",
                WebhookConfigurationWebhookEventsVariant1Item.ParsePending => "parse.pending",
                WebhookConfigurationWebhookEventsVariant1Item.ParseRunning => "parse.running",
                WebhookConfigurationWebhookEventsVariant1Item.ParseSuccess => "parse.success",
                WebhookConfigurationWebhookEventsVariant1Item.UnmappedEvent => "unmapped_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigurationWebhookEventsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "classify.cancelled" => WebhookConfigurationWebhookEventsVariant1Item.ClassifyCancelled,
                "classify.error" => WebhookConfigurationWebhookEventsVariant1Item.ClassifyError,
                "classify.partial_success" => WebhookConfigurationWebhookEventsVariant1Item.ClassifyPartialSuccess,
                "classify.pending" => WebhookConfigurationWebhookEventsVariant1Item.ClassifyPending,
                "classify.success" => WebhookConfigurationWebhookEventsVariant1Item.ClassifySuccess,
                "extract.cancelled" => WebhookConfigurationWebhookEventsVariant1Item.ExtractCancelled,
                "extract.error" => WebhookConfigurationWebhookEventsVariant1Item.ExtractError,
                "extract.partial_success" => WebhookConfigurationWebhookEventsVariant1Item.ExtractPartialSuccess,
                "extract.pending" => WebhookConfigurationWebhookEventsVariant1Item.ExtractPending,
                "extract.success" => WebhookConfigurationWebhookEventsVariant1Item.ExtractSuccess,
                "parse.cancelled" => WebhookConfigurationWebhookEventsVariant1Item.ParseCancelled,
                "parse.error" => WebhookConfigurationWebhookEventsVariant1Item.ParseError,
                "parse.partial_success" => WebhookConfigurationWebhookEventsVariant1Item.ParsePartialSuccess,
                "parse.pending" => WebhookConfigurationWebhookEventsVariant1Item.ParsePending,
                "parse.running" => WebhookConfigurationWebhookEventsVariant1Item.ParseRunning,
                "parse.success" => WebhookConfigurationWebhookEventsVariant1Item.ParseSuccess,
                "unmapped_event" => WebhookConfigurationWebhookEventsVariant1Item.UnmappedEvent,
                _ => null,
            };
        }
    }
}