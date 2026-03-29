//HintName: G.Models.ByoPhoneNumberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is to bring your own phone numbers from your own SIP trunks or Carriers.
    /// </summary>
    public enum ByoPhoneNumberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        ByoPhoneNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ByoPhoneNumberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ByoPhoneNumberProvider value)
        {
            return value switch
            {
                ByoPhoneNumberProvider.ByoPhoneNumber => "byo-phone-number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ByoPhoneNumberProvider? ToEnum(string value)
        {
            return value switch
            {
                "byo-phone-number" => ByoPhoneNumberProvider.ByoPhoneNumber,
                _ => null,
            };
        }
    }
}