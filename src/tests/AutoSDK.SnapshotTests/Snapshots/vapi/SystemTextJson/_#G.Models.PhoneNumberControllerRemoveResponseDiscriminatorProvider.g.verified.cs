//HintName: G.Models.PhoneNumberControllerRemoveResponseDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumberControllerRemoveResponseDiscriminatorProvider
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
    public static class PhoneNumberControllerRemoveResponseDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberControllerRemoveResponseDiscriminatorProvider value)
        {
            return value switch
            {
                PhoneNumberControllerRemoveResponseDiscriminatorProvider.ByoPhoneNumber => "byo-phone-number",
                PhoneNumberControllerRemoveResponseDiscriminatorProvider.Telnyx => "telnyx",
                PhoneNumberControllerRemoveResponseDiscriminatorProvider.Twilio => "twilio",
                PhoneNumberControllerRemoveResponseDiscriminatorProvider.Vapi => "vapi",
                PhoneNumberControllerRemoveResponseDiscriminatorProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberControllerRemoveResponseDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "byo-phone-number" => PhoneNumberControllerRemoveResponseDiscriminatorProvider.ByoPhoneNumber,
                "telnyx" => PhoneNumberControllerRemoveResponseDiscriminatorProvider.Telnyx,
                "twilio" => PhoneNumberControllerRemoveResponseDiscriminatorProvider.Twilio,
                "vapi" => PhoneNumberControllerRemoveResponseDiscriminatorProvider.Vapi,
                "vonage" => PhoneNumberControllerRemoveResponseDiscriminatorProvider.Vonage,
                _ => null,
            };
        }
    }
}