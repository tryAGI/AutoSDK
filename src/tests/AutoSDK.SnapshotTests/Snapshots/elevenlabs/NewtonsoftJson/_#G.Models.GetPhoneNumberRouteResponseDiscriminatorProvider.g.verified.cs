//HintName: G.Models.GetPhoneNumberRouteResponseDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPhoneNumberRouteResponseDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_trunk")]
        SipTrunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
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
                GetPhoneNumberRouteResponseDiscriminatorProvider.SipTrunk => "sip_trunk",
                GetPhoneNumberRouteResponseDiscriminatorProvider.Twilio => "twilio",
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
                "sip_trunk" => GetPhoneNumberRouteResponseDiscriminatorProvider.SipTrunk,
                "twilio" => GetPhoneNumberRouteResponseDiscriminatorProvider.Twilio,
                _ => null,
            };
        }
    }
}