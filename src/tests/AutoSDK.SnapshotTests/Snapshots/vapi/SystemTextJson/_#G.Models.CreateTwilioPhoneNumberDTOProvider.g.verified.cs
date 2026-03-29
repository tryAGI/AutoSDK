//HintName: G.Models.CreateTwilioPhoneNumberDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is to use numbers bought on Twilio.
    /// </summary>
    public enum CreateTwilioPhoneNumberDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTwilioPhoneNumberDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTwilioPhoneNumberDTOProvider value)
        {
            return value switch
            {
                CreateTwilioPhoneNumberDTOProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTwilioPhoneNumberDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => CreateTwilioPhoneNumberDTOProvider.Twilio,
                _ => null,
            };
        }
    }
}