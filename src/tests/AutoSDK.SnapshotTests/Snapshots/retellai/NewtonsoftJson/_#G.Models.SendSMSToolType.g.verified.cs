//HintName: G.Models.SendSMSToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SendSMSToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="send_sms")]
        SendSms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendSMSToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SendSMSToolType value)
        {
            return value switch
            {
                SendSMSToolType.SendSms => "send_sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendSMSToolType? ToEnum(string value)
        {
            return value switch
            {
                "send_sms" => SendSMSToolType.SendSms,
                _ => null,
            };
        }
    }
}