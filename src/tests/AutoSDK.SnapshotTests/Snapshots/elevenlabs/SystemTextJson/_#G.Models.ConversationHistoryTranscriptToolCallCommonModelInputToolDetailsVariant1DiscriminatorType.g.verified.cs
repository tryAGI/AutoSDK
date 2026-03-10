//HintName: G.Models.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType
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
    public static class ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.ApiIntegrationWebhook => "api_integration_webhook",
                ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Client => "client",
                ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Mcp => "mcp",
                ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_webhook" => ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.ApiIntegrationWebhook,
                "client" => ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Client,
                "mcp" => ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Mcp,
                "webhook" => ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}