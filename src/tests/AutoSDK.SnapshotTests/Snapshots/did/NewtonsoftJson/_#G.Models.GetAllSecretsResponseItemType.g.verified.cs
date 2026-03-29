//HintName: G.Models.GetAllSecretsResponseItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication types supported by the secrets service
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAllSecretsResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key")]
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bearer")]
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oauth2")]
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