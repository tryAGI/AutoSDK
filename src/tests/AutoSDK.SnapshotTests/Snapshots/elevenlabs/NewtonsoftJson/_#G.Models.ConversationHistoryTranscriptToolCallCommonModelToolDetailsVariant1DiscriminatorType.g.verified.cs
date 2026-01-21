//HintName: G.Models.ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorType
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
    public static class ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorType.Client => "client",
                ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorType.Client,
                "webhook" => ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}