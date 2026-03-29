//HintName: G.Models.SipRequestToolVerb.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The SIP method to send.
    /// </summary>
    public enum SipRequestToolVerb
    {
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        Notify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SipRequestToolVerbExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SipRequestToolVerb value)
        {
            return value switch
            {
                SipRequestToolVerb.Info => "INFO",
                SipRequestToolVerb.Message => "MESSAGE",
                SipRequestToolVerb.Notify => "NOTIFY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SipRequestToolVerb? ToEnum(string value)
        {
            return value switch
            {
                "INFO" => SipRequestToolVerb.Info,
                "MESSAGE" => SipRequestToolVerb.Message,
                "NOTIFY" => SipRequestToolVerb.Notify,
                _ => null,
            };
        }
    }
}