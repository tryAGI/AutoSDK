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
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_trunk")]
        SipTrunk,
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
                ListPhoneNumbersRouteResponseItemDiscriminatorProvider.Twilio => "twilio",
                ListPhoneNumbersRouteResponseItemDiscriminatorProvider.SipTrunk => "sip_trunk",
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
                "twilio" => ListPhoneNumbersRouteResponseItemDiscriminatorProvider.Twilio,
                "sip_trunk" => ListPhoneNumbersRouteResponseItemDiscriminatorProvider.SipTrunk,
                _ => null,
            };
        }
    }
}