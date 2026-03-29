//HintName: G.Models.CreateApiKeyAuthSecretRequestDtoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type for the secret.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateApiKeyAuthSecretRequestDtoType
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
    public static class CreateApiKeyAuthSecretRequestDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyAuthSecretRequestDtoType value)
        {
            return value switch
            {
                CreateApiKeyAuthSecretRequestDtoType.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyAuthSecretRequestDtoType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => CreateApiKeyAuthSecretRequestDtoType.ApiKey,
                _ => null,
            };
        }
    }
}