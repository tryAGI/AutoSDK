//HintName: G.Models.SmsToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "sms" for Twilio SMS sending tool.
    /// </summary>
    public enum SmsToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsToolType value)
        {
            return value switch
            {
                SmsToolType.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsToolType? ToEnum(string value)
        {
            return value switch
            {
                "sms" => SmsToolType.Sms,
                _ => null,
            };
        }
    }
}