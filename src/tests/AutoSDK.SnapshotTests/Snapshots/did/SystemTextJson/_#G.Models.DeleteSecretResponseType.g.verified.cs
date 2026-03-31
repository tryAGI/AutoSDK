//HintName: G.Models.DeleteSecretResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication types supported by the secrets service
    /// </summary>
    public enum DeleteSecretResponseType
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
    public static class DeleteSecretResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSecretResponseType value)
        {
            return value switch
            {
                DeleteSecretResponseType.ApiKey => "api_key",
                DeleteSecretResponseType.Basic => "basic",
                DeleteSecretResponseType.Bearer => "bearer",
                DeleteSecretResponseType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSecretResponseType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => DeleteSecretResponseType.ApiKey,
                "basic" => DeleteSecretResponseType.Basic,
                "bearer" => DeleteSecretResponseType.Bearer,
                "oauth2" => DeleteSecretResponseType.Oauth2,
                _ => null,
            };
        }
    }
}