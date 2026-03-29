//HintName: G.Models.PhoneNumberControllerCreateRequestDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumberControllerCreateRequestDiscriminatorProvider
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
    public static class PhoneNumberControllerCreateRequestDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberControllerCreateRequestDiscriminatorProvider value)
        {
            return value switch
            {
                PhoneNumberControllerCreateRequestDiscriminatorProvider.ByoPhoneNumber => "byo-phone-number",
                PhoneNumberControllerCreateRequestDiscriminatorProvider.Telnyx => "telnyx",
                PhoneNumberControllerCreateRequestDiscriminatorProvider.Twilio => "twilio",
                PhoneNumberControllerCreateRequestDiscriminatorProvider.Vapi => "vapi",
                PhoneNumberControllerCreateRequestDiscriminatorProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberControllerCreateRequestDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "byo-phone-number" => PhoneNumberControllerCreateRequestDiscriminatorProvider.ByoPhoneNumber,
                "telnyx" => PhoneNumberControllerCreateRequestDiscriminatorProvider.Telnyx,
                "twilio" => PhoneNumberControllerCreateRequestDiscriminatorProvider.Twilio,
                "vapi" => PhoneNumberControllerCreateRequestDiscriminatorProvider.Vapi,
                "vonage" => PhoneNumberControllerCreateRequestDiscriminatorProvider.Vonage,
                _ => null,
            };
        }
    }
}