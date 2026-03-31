//HintName: G.Models.UpdateAuthSecretRequestDtoApiKeyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type.
    /// </summary>
    public enum UpdateAuthSecretRequestDtoApiKeyType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAuthSecretRequestDtoApiKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAuthSecretRequestDtoApiKeyType value)
        {
            return value switch
            {
                UpdateAuthSecretRequestDtoApiKeyType.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAuthSecretRequestDtoApiKeyType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => UpdateAuthSecretRequestDtoApiKeyType.ApiKey,
                _ => null,
            };
        }
    }
}