//HintName: G.Models.CreateCartesiaCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCartesiaCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cartesia")]
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCartesiaCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCartesiaCredentialDTOProvider value)
        {
            return value switch
            {
                CreateCartesiaCredentialDTOProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCartesiaCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => CreateCartesiaCredentialDTOProvider.Cartesia,
                _ => null,
            };
        }
    }
}