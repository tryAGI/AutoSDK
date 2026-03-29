//HintName: G.Models.TelnyxPhoneNumberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is to use numbers bought on Telnyx.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TelnyxPhoneNumberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="telnyx")]
        Telnyx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TelnyxPhoneNumberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TelnyxPhoneNumberProvider value)
        {
            return value switch
            {
                TelnyxPhoneNumberProvider.Telnyx => "telnyx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TelnyxPhoneNumberProvider? ToEnum(string value)
        {
            return value switch
            {
                "telnyx" => TelnyxPhoneNumberProvider.Telnyx,
                _ => null,
            };
        }
    }
}