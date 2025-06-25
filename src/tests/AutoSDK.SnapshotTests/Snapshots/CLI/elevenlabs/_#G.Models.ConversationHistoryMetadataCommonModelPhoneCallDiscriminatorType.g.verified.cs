//HintName: G.Models.ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SipTrunking,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType value)
        {
            return value switch
            {
                ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType.SipTrunking => "sip_trunking",
                ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunking" => ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType.SipTrunking,
                "twilio" => ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}