//HintName: G.Models.GetAllSecretsResponseItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication types supported by the secrets service
    /// </summary>
    public enum GetAllSecretsResponseItemType
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
    public static class GetAllSecretsResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllSecretsResponseItemType value)
        {
            return value switch
            {
                GetAllSecretsResponseItemType.ApiKey => "api_key",
                GetAllSecretsResponseItemType.Basic => "basic",
                GetAllSecretsResponseItemType.Bearer => "bearer",
                GetAllSecretsResponseItemType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllSecretsResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => GetAllSecretsResponseItemType.ApiKey,
                "basic" => GetAllSecretsResponseItemType.Basic,
                "bearer" => GetAllSecretsResponseItemType.Bearer,
                "oauth2" => GetAllSecretsResponseItemType.Oauth2,
                _ => null,
            };
        }
    }
}