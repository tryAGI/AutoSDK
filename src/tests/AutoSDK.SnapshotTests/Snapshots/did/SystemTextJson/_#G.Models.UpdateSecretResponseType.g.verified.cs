//HintName: G.Models.UpdateSecretResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication types supported by the secrets service
    /// </summary>
    public enum UpdateSecretResponseType
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
    public static class UpdateSecretResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSecretResponseType value)
        {
            return value switch
            {
                UpdateSecretResponseType.ApiKey => "api_key",
                UpdateSecretResponseType.Basic => "basic",
                UpdateSecretResponseType.Bearer => "bearer",
                UpdateSecretResponseType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSecretResponseType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => UpdateSecretResponseType.ApiKey,
                "basic" => UpdateSecretResponseType.Basic,
                "bearer" => UpdateSecretResponseType.Bearer,
                "oauth2" => UpdateSecretResponseType.Oauth2,
                _ => null,
            };
        }
    }
}