//HintName: G.Models.SipRequestToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "sipRequest" for SIP request tool.
    /// </summary>
    public enum SipRequestToolType
    {
        /// <summary>
        /// 
        /// </summary>
        SipRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SipRequestToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SipRequestToolType value)
        {
            return value switch
            {
                SipRequestToolType.SipRequest => "sipRequest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SipRequestToolType? ToEnum(string value)
        {
            return value switch
            {
                "sipRequest" => SipRequestToolType.SipRequest,
                _ => null,
            };
        }
    }
}