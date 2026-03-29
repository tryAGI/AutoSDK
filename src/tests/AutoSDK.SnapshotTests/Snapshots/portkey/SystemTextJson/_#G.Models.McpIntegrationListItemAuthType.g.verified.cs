//HintName: G.Models.McpIntegrationListItemAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpIntegrationListItemAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        Headers,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        OauthAuto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpIntegrationListItemAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpIntegrationListItemAuthType value)
        {
            return value switch
            {
                McpIntegrationListItemAuthType.Headers => "headers",
                McpIntegrationListItemAuthType.None => "none",
                McpIntegrationListItemAuthType.OauthAuto => "oauth_auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpIntegrationListItemAuthType? ToEnum(string value)
        {
            return value switch
            {
                "headers" => McpIntegrationListItemAuthType.Headers,
                "none" => McpIntegrationListItemAuthType.None,
                "oauth_auto" => McpIntegrationListItemAuthType.OauthAuto,
                _ => null,
            };
        }
    }
}