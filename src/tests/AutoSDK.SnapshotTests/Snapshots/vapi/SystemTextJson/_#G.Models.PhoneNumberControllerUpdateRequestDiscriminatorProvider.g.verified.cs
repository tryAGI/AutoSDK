//HintName: G.Models.PhoneNumberControllerUpdateRequestDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumberControllerUpdateRequestDiscriminatorProvider
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
    public static class PhoneNumberControllerUpdateRequestDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberControllerUpdateRequestDiscriminatorProvider value)
        {
            return value switch
            {
                PhoneNumberControllerUpdateRequestDiscriminatorProvider.ByoPhoneNumber => "byo-phone-number",
                PhoneNumberControllerUpdateRequestDiscriminatorProvider.Telnyx => "telnyx",
                PhoneNumberControllerUpdateRequestDiscriminatorProvider.Twilio => "twilio",
                PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vapi => "vapi",
                PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberControllerUpdateRequestDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "byo-phone-number" => PhoneNumberControllerUpdateRequestDiscriminatorProvider.ByoPhoneNumber,
                "telnyx" => PhoneNumberControllerUpdateRequestDiscriminatorProvider.Telnyx,
                "twilio" => PhoneNumberControllerUpdateRequestDiscriminatorProvider.Twilio,
                "vapi" => PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vapi,
                "vonage" => PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vonage,
                _ => null,
            };
        }
    }
}