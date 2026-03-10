//HintName: G.Models.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiIntegrationWebhook,
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.ApiIntegrationWebhook => "api_integration_webhook",
                ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.Client => "client",
                ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.Mcp => "mcp",
                ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_webhook" => ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.ApiIntegrationWebhook,
                "client" => ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.Client,
                "mcp" => ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.Mcp,
                "webhook" => ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}