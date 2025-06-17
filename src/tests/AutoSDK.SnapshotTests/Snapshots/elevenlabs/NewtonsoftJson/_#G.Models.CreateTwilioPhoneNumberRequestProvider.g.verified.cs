//HintName: G.Models.CreateTwilioPhoneNumberRequestProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: twilio
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTwilioPhoneNumberRequestProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTwilioPhoneNumberRequestProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTwilioPhoneNumberRequestProvider value)
        {
            return value switch
            {
                CreateTwilioPhoneNumberRequestProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTwilioPhoneNumberRequestProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => CreateTwilioPhoneNumberRequestProvider.Twilio,
                _ => null,
            };
        }
    }
}