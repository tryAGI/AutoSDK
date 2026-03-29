//HintName: G.Models.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type for the secret.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSecretRequestCreateSecretRequest1BasicAuthenticationType
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
    public static class CreateSecretRequestCreateSecretRequest1BasicAuthenticationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretRequestCreateSecretRequest1BasicAuthenticationType value)
        {
            return value switch
            {
                CreateSecretRequestCreateSecretRequest1BasicAuthenticationType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretRequestCreateSecretRequest1BasicAuthenticationType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateSecretRequestCreateSecretRequest1BasicAuthenticationType.Basic,
                _ => null,
            };
        }
    }
}