//HintName: G.Models.CreateSecretResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication types supported by the secrets service
    /// </summary>
    public enum CreateSecretResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretResponseType value)
        {
            return value switch
            {
                CreateSecretResponseType.ApiKey => "api_key",
                CreateSecretResponseType.Basic => "basic",
                CreateSecretResponseType.Bearer => "bearer",
                CreateSecretResponseType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretResponseType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => CreateSecretResponseType.ApiKey,
                "basic" => CreateSecretResponseType.Basic,
                "bearer" => CreateSecretResponseType.Bearer,
                "oauth2" => CreateSecretResponseType.Oauth2,
                _ => null,
            };
        }
    }
}