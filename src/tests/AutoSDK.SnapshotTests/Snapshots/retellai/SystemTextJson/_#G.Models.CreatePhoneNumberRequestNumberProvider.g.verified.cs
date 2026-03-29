//HintName: G.Models.CreatePhoneNumberRequestNumberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider to purchase the phone number from. Default to twilio.<br/>
    /// Example: twilio
    /// </summary>
    public enum CreatePhoneNumberRequestNumberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Telnyx,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePhoneNumberRequestNumberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePhoneNumberRequestNumberProvider value)
        {
            return value switch
            {
                CreatePhoneNumberRequestNumberProvider.Telnyx => "telnyx",
                CreatePhoneNumberRequestNumberProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePhoneNumberRequestNumberProvider? ToEnum(string value)
        {
            return value switch
            {
                "telnyx" => CreatePhoneNumberRequestNumberProvider.Telnyx,
                "twilio" => CreatePhoneNumberRequestNumberProvider.Twilio,
                _ => null,
            };
        }
    }
}