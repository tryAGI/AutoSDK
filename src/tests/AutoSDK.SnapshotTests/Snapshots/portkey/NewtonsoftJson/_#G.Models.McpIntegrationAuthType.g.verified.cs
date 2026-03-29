//HintName: G.Models.McpIntegrationAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpIntegrationAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="headers")]
        Headers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oauth_auto")]
        OauthAuto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oauth_client_credentials")]
        OauthClientCredentials,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpIntegrationAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpIntegrationAuthType value)
        {
            return value switch
            {
                McpIntegrationAuthType.Headers => "headers",
                McpIntegrationAuthType.None => "none",
                McpIntegrationAuthType.OauthAuto => "oauth_auto",
                McpIntegrationAuthType.OauthClientCredentials => "oauth_client_credentials",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpIntegrationAuthType? ToEnum(string value)
        {
            return value switch
            {
                "headers" => McpIntegrationAuthType.Headers,
                "none" => McpIntegrationAuthType.None,
                "oauth_auto" => McpIntegrationAuthType.OauthAuto,
                "oauth_client_credentials" => McpIntegrationAuthType.OauthClientCredentials,
                _ => null,
            };
        }
    }
}