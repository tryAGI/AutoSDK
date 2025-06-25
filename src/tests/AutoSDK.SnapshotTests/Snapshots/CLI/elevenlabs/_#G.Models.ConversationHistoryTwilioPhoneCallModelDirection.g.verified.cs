//HintName: G.Models.ConversationHistoryTwilioPhoneCallModelDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTwilioPhoneCallModelDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTwilioPhoneCallModelDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTwilioPhoneCallModelDirection value)
        {
            return value switch
            {
                ConversationHistoryTwilioPhoneCallModelDirection.Inbound => "inbound",
                ConversationHistoryTwilioPhoneCallModelDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTwilioPhoneCallModelDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => ConversationHistoryTwilioPhoneCallModelDirection.Inbound,
                "outbound" => ConversationHistoryTwilioPhoneCallModelDirection.Outbound,
                _ => null,
            };
        }
    }
}