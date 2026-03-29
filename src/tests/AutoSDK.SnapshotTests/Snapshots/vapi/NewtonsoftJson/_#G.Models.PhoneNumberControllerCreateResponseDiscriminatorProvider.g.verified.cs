//HintName: G.Models.PhoneNumberControllerCreateResponseDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PhoneNumberControllerCreateResponseDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="byo-phone-number")]
        ByoPhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="telnyx")]
        Telnyx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapi")]
        Vapi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vonage")]
        Vonage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberControllerCreateResponseDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberControllerCreateResponseDiscriminatorProvider value)
        {
            return value switch
            {
                PhoneNumberControllerCreateResponseDiscriminatorProvider.ByoPhoneNumber => "byo-phone-number",
                PhoneNumberControllerCreateResponseDiscriminatorProvider.Telnyx => "telnyx",
                PhoneNumberControllerCreateResponseDiscriminatorProvider.Twilio => "twilio",
                PhoneNumberControllerCreateResponseDiscriminatorProvider.Vapi => "vapi",
                PhoneNumberControllerCreateResponseDiscriminatorProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberControllerCreateResponseDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "byo-phone-number" => PhoneNumberControllerCreateResponseDiscriminatorProvider.ByoPhoneNumber,
                "telnyx" => PhoneNumberControllerCreateResponseDiscriminatorProvider.Telnyx,
                "twilio" => PhoneNumberControllerCreateResponseDiscriminatorProvider.Twilio,
                "vapi" => PhoneNumberControllerCreateResponseDiscriminatorProvider.Vapi,
                "vonage" => PhoneNumberControllerCreateResponseDiscriminatorProvider.Vonage,
                _ => null,
            };
        }
    }
}