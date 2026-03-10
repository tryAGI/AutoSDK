//HintName: G.Models.ReferencedToolCommonModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool
    /// </summary>
    public enum ReferencedToolCommonModelType
    {
        /// <summary>
        /// 
        /// </summary>
        System,
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
        Workflow,
        /// <summary>
        /// 
        /// </summary>
        ApiIntegrationWebhook,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReferencedToolCommonModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReferencedToolCommonModelType value)
        {
            return value switch
            {
                ReferencedToolCommonModelType.System => "system",
                ReferencedToolCommonModelType.Webhook => "webhook",
                ReferencedToolCommonModelType.Client => "client",
                ReferencedToolCommonModelType.Workflow => "workflow",
                ReferencedToolCommonModelType.ApiIntegrationWebhook => "api_integration_webhook",
                ReferencedToolCommonModelType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReferencedToolCommonModelType? ToEnum(string value)
        {
            return value switch
            {
                "system" => ReferencedToolCommonModelType.System,
                "webhook" => ReferencedToolCommonModelType.Webhook,
                "client" => ReferencedToolCommonModelType.Client,
                "workflow" => ReferencedToolCommonModelType.Workflow,
                "api_integration_webhook" => ReferencedToolCommonModelType.ApiIntegrationWebhook,
                "mcp" => ReferencedToolCommonModelType.Mcp,
                _ => null,
            };
        }
    }
}