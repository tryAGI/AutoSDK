//HintName: G.Models.CreateSecretRequestDtoBasicAuthenticationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type for the secret.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSecretRequestDtoBasicAuthenticationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretRequestDtoBasicAuthenticationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretRequestDtoBasicAuthenticationType value)
        {
            return value switch
            {
                CreateSecretRequestDtoBasicAuthenticationType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretRequestDtoBasicAuthenticationType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateSecretRequestDtoBasicAuthenticationType.Basic,
                _ => null,
            };
        }
    }
}