//HintName: G.Models.UpdateMcpIntegrationAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateMcpIntegrationAuthType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMcpIntegrationAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMcpIntegrationAuthType value)
        {
            return value switch
            {
                UpdateMcpIntegrationAuthType.Headers => "headers",
                UpdateMcpIntegrationAuthType.None => "none",
                UpdateMcpIntegrationAuthType.OauthAuto => "oauth_auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMcpIntegrationAuthType? ToEnum(string value)
        {
            return value switch
            {
                "headers" => UpdateMcpIntegrationAuthType.Headers,
                "none" => UpdateMcpIntegrationAuthType.None,
                "oauth_auto" => UpdateMcpIntegrationAuthType.OauthAuto,
                _ => null,
            };
        }
    }
}