//HintName: G.Models.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="client")]
        Client,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Client => "client",
                ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Client,
                "webhook" => ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}