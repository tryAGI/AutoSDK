//HintName: G.Models.TelephonyProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TelephonyProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        SipTrunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TelephonyProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TelephonyProvider value)
        {
            return value switch
            {
                TelephonyProvider.Twilio => "twilio",
                TelephonyProvider.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TelephonyProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => TelephonyProvider.Twilio,
                "sip_trunk" => TelephonyProvider.SipTrunk,
                _ => null,
            };
        }
    }
}