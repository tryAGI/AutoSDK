//HintName: G.Models.ConversationHistoryTranscriptOtherToolsResultCommonModelType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptOtherToolsResultCommonModelType2
    {
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
    public static class ConversationHistoryTranscriptOtherToolsResultCommonModelType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptOtherToolsResultCommonModelType2 value)
        {
            return value switch
            {
                ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Client => "client",
                ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Mcp => "mcp",
                ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptOtherToolsResultCommonModelType2? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Client,
                "mcp" => ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Mcp,
                "webhook" => ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Webhook,
                _ => null,
            };
        }
    }
}