//HintName: G.Models.ListPhoneNumbersRouteResponseItemDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListPhoneNumbersRouteResponseItemDiscriminatorProvider
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
    public static class ListPhoneNumbersRouteResponseItemDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPhoneNumbersRouteResponseItemDiscriminatorProvider value)
        {
            return value switch
            {
                ListPhoneNumbersRouteResponseItemDiscriminatorProvider.SipTrunk => "sip_trunk",
                ListPhoneNumbersRouteResponseItemDiscriminatorProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPhoneNumbersRouteResponseItemDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => ListPhoneNumbersRouteResponseItemDiscriminatorProvider.SipTrunk,
                "twilio" => ListPhoneNumbersRouteResponseItemDiscriminatorProvider.Twilio,
                _ => null,
            };
        }
    }
}