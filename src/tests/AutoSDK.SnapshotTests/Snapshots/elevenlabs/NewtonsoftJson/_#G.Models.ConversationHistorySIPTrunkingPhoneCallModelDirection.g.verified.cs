//HintName: G.Models.ConversationHistorySIPTrunkingPhoneCallModelDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistorySIPTrunkingPhoneCallModelDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inbound")]
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outbound")]
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistorySIPTrunkingPhoneCallModelDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistorySIPTrunkingPhoneCallModelDirection value)
        {
            return value switch
            {
                ConversationHistorySIPTrunkingPhoneCallModelDirection.Inbound => "inbound",
                ConversationHistorySIPTrunkingPhoneCallModelDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistorySIPTrunkingPhoneCallModelDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => ConversationHistorySIPTrunkingPhoneCallModelDirection.Inbound,
                "outbound" => ConversationHistorySIPTrunkingPhoneCallModelDirection.Outbound,
                _ => null,
            };
        }
    }
}