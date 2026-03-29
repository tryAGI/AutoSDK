//HintName: G.Models.VapiPhoneNumberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is to create free SIP phone numbers on Vapi.
    /// </summary>
    public enum VapiPhoneNumberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Vapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiPhoneNumberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiPhoneNumberProvider value)
        {
            return value switch
            {
                VapiPhoneNumberProvider.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiPhoneNumberProvider? ToEnum(string value)
        {
            return value switch
            {
                "vapi" => VapiPhoneNumberProvider.Vapi,
                _ => null,
            };
        }
    }
}