//HintName: G.Models.VonagePhoneNumberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is to use numbers bought on Vonage.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VonagePhoneNumberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vonage")]
        Vonage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VonagePhoneNumberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VonagePhoneNumberProvider value)
        {
            return value switch
            {
                VonagePhoneNumberProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VonagePhoneNumberProvider? ToEnum(string value)
        {
            return value switch
            {
                "vonage" => VonagePhoneNumberProvider.Vonage,
                _ => null,
            };
        }
    }
}