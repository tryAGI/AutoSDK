//HintName: G.Models.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType
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
    public static class ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType value)
        {
            return value switch
            {
                ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.SipTrunking => "sip_trunking",
                ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunking" => ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.SipTrunking,
                "twilio" => ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}