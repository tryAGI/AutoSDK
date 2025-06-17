//HintName: G.Models.ConversationHistoryTranscriptToolCallWebhookDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: webhook
    /// </summary>
    public enum ConversationHistoryTranscriptToolCallWebhookDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptToolCallWebhookDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptToolCallWebhookDetailsType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptToolCallWebhookDetailsType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptToolCallWebhookDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ConversationHistoryTranscriptToolCallWebhookDetailsType.Webhook,
                _ => null,
            };
        }
    }
}