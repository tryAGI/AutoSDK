//HintName: G.Models.CreateMcpIntegrationAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMcpIntegrationAuthType
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
    public static class CreateMcpIntegrationAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMcpIntegrationAuthType value)
        {
            return value switch
            {
                CreateMcpIntegrationAuthType.Headers => "headers",
                CreateMcpIntegrationAuthType.None => "none",
                CreateMcpIntegrationAuthType.OauthAuto => "oauth_auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMcpIntegrationAuthType? ToEnum(string value)
        {
            return value switch
            {
                "headers" => CreateMcpIntegrationAuthType.Headers,
                "none" => CreateMcpIntegrationAuthType.None,
                "oauth_auto" => CreateMcpIntegrationAuthType.OauthAuto,
                _ => null,
            };
        }
    }
}