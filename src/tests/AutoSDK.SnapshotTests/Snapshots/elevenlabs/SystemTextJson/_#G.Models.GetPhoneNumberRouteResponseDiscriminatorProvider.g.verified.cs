//HintName: G.Models.GetPhoneNumberRouteResponseDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPhoneNumberRouteResponseDiscriminatorProvider
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
    public static class GetPhoneNumberRouteResponseDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPhoneNumberRouteResponseDiscriminatorProvider value)
        {
            return value switch
            {
                GetPhoneNumberRouteResponseDiscriminatorProvider.Twilio => "twilio",
                GetPhoneNumberRouteResponseDiscriminatorProvider.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPhoneNumberRouteResponseDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => GetPhoneNumberRouteResponseDiscriminatorProvider.Twilio,
                "sip_trunk" => GetPhoneNumberRouteResponseDiscriminatorProvider.SipTrunk,
                _ => null,
            };
        }
    }
}