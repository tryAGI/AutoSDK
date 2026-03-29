//HintName: G.Models.CreateVonagePhoneNumberDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is to use numbers bought on Vonage.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVonagePhoneNumberDTOProvider
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
    public static class CreateVonagePhoneNumberDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVonagePhoneNumberDTOProvider value)
        {
            return value switch
            {
                CreateVonagePhoneNumberDTOProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVonagePhoneNumberDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "vonage" => CreateVonagePhoneNumberDTOProvider.Vonage,
                _ => null,
            };
        }
    }
}