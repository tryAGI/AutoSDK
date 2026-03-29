//HintName: G.Models.CreateSecretRequestCreateSecretRequest1ApiKeyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type for the secret.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSecretRequestCreateSecretRequest1ApiKeyType
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
    public static class CreateSecretRequestCreateSecretRequest1ApiKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretRequestCreateSecretRequest1ApiKeyType value)
        {
            return value switch
            {
                CreateSecretRequestCreateSecretRequest1ApiKeyType.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretRequestCreateSecretRequest1ApiKeyType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => CreateSecretRequestCreateSecretRequest1ApiKeyType.ApiKey,
                _ => null,
            };
        }
    }
}