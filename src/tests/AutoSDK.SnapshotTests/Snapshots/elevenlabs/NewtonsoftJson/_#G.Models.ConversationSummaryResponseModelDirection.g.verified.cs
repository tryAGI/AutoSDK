//HintName: G.Models.ConversationSummaryResponseModelDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationSummaryResponseModelDirection
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
    public static class ConversationSummaryResponseModelDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationSummaryResponseModelDirection value)
        {
            return value switch
            {
                ConversationSummaryResponseModelDirection.Inbound => "inbound",
                ConversationSummaryResponseModelDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationSummaryResponseModelDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => ConversationSummaryResponseModelDirection.Inbound,
                "outbound" => ConversationSummaryResponseModelDirection.Outbound,
                _ => null,
            };
        }
    }
}