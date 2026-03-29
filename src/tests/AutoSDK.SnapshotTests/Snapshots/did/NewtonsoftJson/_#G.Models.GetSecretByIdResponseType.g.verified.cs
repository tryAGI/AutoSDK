//HintName: G.Models.GetSecretByIdResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication types supported by the secrets service
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetSecretByIdResponseType
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