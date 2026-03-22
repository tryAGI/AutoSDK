//HintName: G.Models.UpdatePhoneNumberRouteResponseDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdatePhoneNumberRouteResponseDiscriminatorProvider
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
    public static class UpdatePhoneNumberRouteResponseDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePhoneNumberRouteResponseDiscriminatorProvider value)
        {
            return value switch
            {
                UpdatePhoneNumberRouteResponseDiscriminatorProvider.SipTrunk => "sip_trunk",
                UpdatePhoneNumberRouteResponseDiscriminatorProvider.Twilio => "twilio",
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
                "sip_trunk" => UpdatePhoneNumberRouteResponseDiscriminatorProvider.SipTrunk,
                "twilio" => UpdatePhoneNumberRouteResponseDiscriminatorProvider.Twilio,
                _ => null,
            };
        }
    }
}