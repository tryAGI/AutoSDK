//HintName: G.Models.ToolTypeFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolTypeFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_integration_webhook")]
        ApiIntegrationWebhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="client")]
        Client,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolTypeFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolTypeFilter value)
        {
            return value switch
            {
                ToolTypeFilter.ApiIntegrationWebhook => "api_integration_webhook",
                ToolTypeFilter.Client => "client",
                ToolTypeFilter.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolTypeFilter? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_webhook" => ToolTypeFilter.ApiIntegrationWebhook,
                "client" => ToolTypeFilter.Client,
                "webhook" => ToolTypeFilter.Webhook,
                _ => null,
            };
        }
    }
}