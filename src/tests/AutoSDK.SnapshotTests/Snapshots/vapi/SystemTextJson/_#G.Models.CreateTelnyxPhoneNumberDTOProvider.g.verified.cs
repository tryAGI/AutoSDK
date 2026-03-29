//HintName: G.Models.CreateTelnyxPhoneNumberDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is to use numbers bought on Telnyx.
    /// </summary>
    public enum CreateTelnyxPhoneNumberDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Telnyx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTelnyxPhoneNumberDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTelnyxPhoneNumberDTOProvider value)
        {
            return value switch
            {
                CreateTelnyxPhoneNumberDTOProvider.Telnyx => "telnyx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTelnyxPhoneNumberDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "telnyx" => CreateTelnyxPhoneNumberDTOProvider.Telnyx,
                _ => null,
            };
        }
    }
}