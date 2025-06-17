//HintName: G.Models.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider
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
    public static class ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider value)
        {
            return value switch
            {
                ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider.Twilio => "twilio",
                ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider.Twilio,
                "sip_trunk" => ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider.SipTrunk,
                _ => null,
            };
        }
    }
}