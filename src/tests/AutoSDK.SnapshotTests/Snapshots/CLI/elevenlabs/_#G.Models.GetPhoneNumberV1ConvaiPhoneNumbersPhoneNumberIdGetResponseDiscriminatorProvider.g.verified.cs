//HintName: G.Models.GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProvider
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
    public static class GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProvider value)
        {
            return value switch
            {
                GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProvider.Twilio => "twilio",
                GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProvider.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProvider.Twilio,
                "sip_trunk" => GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProvider.SipTrunk,
                _ => null,
            };
        }
    }
}