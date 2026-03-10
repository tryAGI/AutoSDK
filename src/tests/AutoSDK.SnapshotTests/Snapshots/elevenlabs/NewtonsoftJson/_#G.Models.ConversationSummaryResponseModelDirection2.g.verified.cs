//HintName: G.Models.ConversationSummaryResponseModelDirection2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationSummaryResponseModelDirection2
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
    public static class ConversationSummaryResponseModelDirection2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationSummaryResponseModelDirection2 value)
        {
            return value switch
            {
                ConversationSummaryResponseModelDirection2.Inbound => "inbound",
                ConversationSummaryResponseModelDirection2.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationSummaryResponseModelDirection2? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => ConversationSummaryResponseModelDirection2.Inbound,
                "outbound" => ConversationSummaryResponseModelDirection2.Outbound,
                _ => null,
            };
        }
    }
}