//HintName: G.Models.PhoneNumberControllerFindOneResponseDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumberControllerFindOneResponseDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        ByoPhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        Telnyx,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Vapi,
        /// <summary>
        /// 
        /// </summary>
        Vonage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberControllerFindOneResponseDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberControllerFindOneResponseDiscriminatorProvider value)
        {
            return value switch
            {
                PhoneNumberControllerFindOneResponseDiscriminatorProvider.ByoPhoneNumber => "byo-phone-number",
                PhoneNumberControllerFindOneResponseDiscriminatorProvider.Telnyx => "telnyx",
                PhoneNumberControllerFindOneResponseDiscriminatorProvider.Twilio => "twilio",
                PhoneNumberControllerFindOneResponseDiscriminatorProvider.Vapi => "vapi",
                PhoneNumberControllerFindOneResponseDiscriminatorProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberControllerFindOneResponseDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "byo-phone-number" => PhoneNumberControllerFindOneResponseDiscriminatorProvider.ByoPhoneNumber,
                "telnyx" => PhoneNumberControllerFindOneResponseDiscriminatorProvider.Telnyx,
                "twilio" => PhoneNumberControllerFindOneResponseDiscriminatorProvider.Twilio,
                "vapi" => PhoneNumberControllerFindOneResponseDiscriminatorProvider.Vapi,
                "vonage" => PhoneNumberControllerFindOneResponseDiscriminatorProvider.Vonage,
                _ => null,
            };
        }
    }
}