//HintName: G.Models.CreateGcpCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateGcpCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gcp")]
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGcpCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGcpCredentialDTOProvider value)
        {
            return value switch
            {
                CreateGcpCredentialDTOProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGcpCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "gcp" => CreateGcpCredentialDTOProvider.Gcp,
                _ => null,
            };
        }
    }
}