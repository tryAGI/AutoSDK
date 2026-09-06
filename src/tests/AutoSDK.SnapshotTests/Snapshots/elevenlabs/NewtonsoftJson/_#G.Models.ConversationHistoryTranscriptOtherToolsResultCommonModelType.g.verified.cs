//HintName: G.Models.ConversationHistoryTranscriptOtherToolsResultCommonModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptOtherToolsResultCommonModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="client")]
        Client,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp")]
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptOtherToolsResultCommonModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptOtherToolsResultCommonModelType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptOtherToolsResultCommonModelType.Client => "client",
                ConversationHistoryTranscriptOtherToolsResultCommonModelType.Mcp => "mcp",
                ConversationHistoryTranscriptOtherToolsResultCommonModelType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptOtherToolsResultCommonModelType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationHistoryTranscriptOtherToolsResultCommonModelType.Client,
                "mcp" => ConversationHistoryTranscriptOtherToolsResultCommonModelType.Mcp,
                "webhook" => ConversationHistoryTranscriptOtherToolsResultCommonModelType.Webhook,
                _ => null,
            };
        }
    }
}