//HintName: G.Models.ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
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
                "twilio" => ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}