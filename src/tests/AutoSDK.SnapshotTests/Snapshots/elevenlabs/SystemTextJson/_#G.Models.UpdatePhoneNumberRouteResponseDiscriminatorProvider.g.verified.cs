//HintName: G.Models.UpdatePhoneNumberRouteResponseDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdatePhoneNumberRouteResponseDiscriminatorProvider
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
    public static class UpdatePhoneNumberRouteResponseDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePhoneNumberRouteResponseDiscriminatorProvider value)
        {
            return value switch
            {
                UpdatePhoneNumberRouteResponseDiscriminatorProvider.Twilio => "twilio",
                UpdatePhoneNumberRouteResponseDiscriminatorProvider.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePhoneNumberRouteResponseDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => UpdatePhoneNumberRouteResponseDiscriminatorProvider.Twilio,
                "sip_trunk" => UpdatePhoneNumberRouteResponseDiscriminatorProvider.SipTrunk,
                _ => null,
            };
        }
    }
}