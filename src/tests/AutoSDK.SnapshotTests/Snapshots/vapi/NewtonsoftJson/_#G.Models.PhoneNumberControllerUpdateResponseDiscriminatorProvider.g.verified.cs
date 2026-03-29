//HintName: G.Models.PhoneNumberControllerUpdateResponseDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PhoneNumberControllerUpdateResponseDiscriminatorProvider
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
    public static class PhoneNumberControllerUpdateResponseDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberControllerUpdateResponseDiscriminatorProvider value)
        {
            return value switch
            {
                PhoneNumberControllerUpdateResponseDiscriminatorProvider.ByoPhoneNumber => "byo-phone-number",
                PhoneNumberControllerUpdateResponseDiscriminatorProvider.Telnyx => "telnyx",
                PhoneNumberControllerUpdateResponseDiscriminatorProvider.Twilio => "twilio",
                PhoneNumberControllerUpdateResponseDiscriminatorProvider.Vapi => "vapi",
                PhoneNumberControllerUpdateResponseDiscriminatorProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberControllerUpdateResponseDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "byo-phone-number" => PhoneNumberControllerUpdateResponseDiscriminatorProvider.ByoPhoneNumber,
                "telnyx" => PhoneNumberControllerUpdateResponseDiscriminatorProvider.Telnyx,
                "twilio" => PhoneNumberControllerUpdateResponseDiscriminatorProvider.Twilio,
                "vapi" => PhoneNumberControllerUpdateResponseDiscriminatorProvider.Vapi,
                "vonage" => PhoneNumberControllerUpdateResponseDiscriminatorProvider.Vonage,
                _ => null,
            };
        }
    }
}