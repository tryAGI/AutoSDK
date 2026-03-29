//HintName: G.Models.CreateSecretRequestDtoApiKeyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type for the secret.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSecretRequestDtoApiKeyType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key")]
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretRequestDtoApiKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretRequestDtoApiKeyType value)
        {
            return value switch
            {
                CreateSecretRequestDtoApiKeyType.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretRequestDtoApiKeyType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => CreateSecretRequestDtoApiKeyType.ApiKey,
                _ => null,
            };
        }
    }
}