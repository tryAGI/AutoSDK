//HintName: G.Models.GetSecretByIdResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication types supported by the secrets service
    /// </summary>
    public enum GetSecretByIdResponseType
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
    public static class GetSecretByIdResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecretByIdResponseType value)
        {
            return value switch
            {
                GetSecretByIdResponseType.ApiKey => "api_key",
                GetSecretByIdResponseType.Basic => "basic",
                GetSecretByIdResponseType.Bearer => "bearer",
                GetSecretByIdResponseType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecretByIdResponseType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => GetSecretByIdResponseType.ApiKey,
                "basic" => GetSecretByIdResponseType.Basic,
                "bearer" => GetSecretByIdResponseType.Bearer,
                "oauth2" => GetSecretByIdResponseType.Oauth2,
                _ => null,
            };
        }
    }
}