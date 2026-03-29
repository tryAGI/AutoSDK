//HintName: G.Models.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumberControllerFindAllResponseItemDiscriminatorProvider
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
    public static class PhoneNumberControllerFindAllResponseItemDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberControllerFindAllResponseItemDiscriminatorProvider value)
        {
            return value switch
            {
                PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.ByoPhoneNumber => "byo-phone-number",
                PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.Telnyx => "telnyx",
                PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.Twilio => "twilio",
                PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.Vapi => "vapi",
                PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberControllerFindAllResponseItemDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "byo-phone-number" => PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.ByoPhoneNumber,
                "telnyx" => PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.Telnyx,
                "twilio" => PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.Twilio,
                "vapi" => PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.Vapi,
                "vonage" => PhoneNumberControllerFindAllResponseItemDiscriminatorProvider.Vonage,
                _ => null,
            };
        }
    }
}