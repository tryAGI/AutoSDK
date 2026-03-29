//HintName: G.Models.CreateVapiPhoneNumberDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is to create free SIP phone numbers on Vapi.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVapiPhoneNumberDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapi")]
        Vapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVapiPhoneNumberDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVapiPhoneNumberDTOProvider value)
        {
            return value switch
            {
                CreateVapiPhoneNumberDTOProvider.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVapiPhoneNumberDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "vapi" => CreateVapiPhoneNumberDTOProvider.Vapi,
                _ => null,
            };
        }
    }
}