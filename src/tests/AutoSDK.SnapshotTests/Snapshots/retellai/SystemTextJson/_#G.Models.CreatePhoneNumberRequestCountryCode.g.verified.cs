//HintName: G.Models.CreatePhoneNumberRequestCountryCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ISO 3166-1 alpha-2 country code of the number you are trying to purchase. If left empty, will default to "US".<br/>
    /// Example: US
    /// </summary>
    public enum CreatePhoneNumberRequestCountryCode
    {
        /// <summary>
        /// 
        /// </summary>
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePhoneNumberRequestCountryCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePhoneNumberRequestCountryCode value)
        {
            return value switch
            {
                CreatePhoneNumberRequestCountryCode.Ca => "CA",
                CreatePhoneNumberRequestCountryCode.Us => "US",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePhoneNumberRequestCountryCode? ToEnum(string value)
        {
            return value switch
            {
                "CA" => CreatePhoneNumberRequestCountryCode.Ca,
                "US" => CreatePhoneNumberRequestCountryCode.Us,
                _ => null,
            };
        }
    }
}