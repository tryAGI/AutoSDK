//HintName: G.Models.ToolTypeFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolTypeFilter
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        ApiIntegrationWebhook,
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
                ToolTypeFilter.Webhook => "webhook",
                ToolTypeFilter.Client => "client",
                ToolTypeFilter.ApiIntegrationWebhook => "api_integration_webhook",
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
                "webhook" => ToolTypeFilter.Webhook,
                "client" => ToolTypeFilter.Client,
                "api_integration_webhook" => ToolTypeFilter.ApiIntegrationWebhook,
                _ => null,
            };
        }
    }
}