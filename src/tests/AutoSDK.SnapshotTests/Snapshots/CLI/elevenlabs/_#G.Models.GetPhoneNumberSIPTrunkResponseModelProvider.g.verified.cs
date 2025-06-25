//HintName: G.Models.GetPhoneNumberSIPTrunkResponseModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Phone provider<br/>
    /// Default Value: sip_trunk
    /// </summary>
    public enum GetPhoneNumberSIPTrunkResponseModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        SipTrunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPhoneNumberSIPTrunkResponseModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPhoneNumberSIPTrunkResponseModelProvider value)
        {
            return value switch
            {
                GetPhoneNumberSIPTrunkResponseModelProvider.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPhoneNumberSIPTrunkResponseModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => GetPhoneNumberSIPTrunkResponseModelProvider.SipTrunk,
                _ => null,
            };
        }
    }
}