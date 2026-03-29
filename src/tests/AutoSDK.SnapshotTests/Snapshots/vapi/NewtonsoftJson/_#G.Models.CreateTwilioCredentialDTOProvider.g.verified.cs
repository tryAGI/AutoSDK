//HintName: G.Models.CreateTwilioCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTwilioCredentialDTOProvider
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
    public static class CreateTwilioCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTwilioCredentialDTOProvider value)
        {
            return value switch
            {
                CreateTwilioCredentialDTOProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTwilioCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => CreateTwilioCredentialDTOProvider.Twilio,
                _ => null,
            };
        }
    }
}