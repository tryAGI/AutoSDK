//HintName: G.Models.SecretAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication types supported by the secrets service
    /// </summary>
    public enum SecretAuthType
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
    public static class SecretAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretAuthType value)
        {
            return value switch
            {
                SecretAuthType.ApiKey => "api_key",
                SecretAuthType.Basic => "basic",
                SecretAuthType.Bearer => "bearer",
                SecretAuthType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretAuthType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => SecretAuthType.ApiKey,
                "basic" => SecretAuthType.Basic,
                "bearer" => SecretAuthType.Bearer,
                "oauth2" => SecretAuthType.Oauth2,
                _ => null,
            };
        }
    }
}