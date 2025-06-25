//HintName: G.Models.ConversationHistorySIPTrunkingPhoneCallModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistorySIPTrunkingPhoneCallModelType
    {
        /// <summary>
        /// 
        /// </summary>
        SipTrunking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistorySIPTrunkingPhoneCallModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistorySIPTrunkingPhoneCallModelType value)
        {
            return value switch
            {
                ConversationHistorySIPTrunkingPhoneCallModelType.SipTrunking => "sip_trunking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistorySIPTrunkingPhoneCallModelType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunking" => ConversationHistorySIPTrunkingPhoneCallModelType.SipTrunking,
                _ => null,
            };
        }
    }
}