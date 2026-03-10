//HintName: G.Models.ToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolType
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
        Mcp,
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
        ApiIntegrationMcp,
        /// <summary>
        /// 
        /// </summary>
        Smb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolType value)
        {
            return value switch
            {
                ToolType.System => "system",
                ToolType.Webhook => "webhook",
                ToolType.Client => "client",
                ToolType.Mcp => "mcp",
                ToolType.Workflow => "workflow",
                ToolType.ApiIntegrationWebhook => "api_integration_webhook",
                ToolType.ApiIntegrationMcp => "api_integration_mcp",
                ToolType.Smb => "smb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolType? ToEnum(string value)
        {
            return value switch
            {
                "system" => ToolType.System,
                "webhook" => ToolType.Webhook,
                "client" => ToolType.Client,
                "mcp" => ToolType.Mcp,
                "workflow" => ToolType.Workflow,
                "api_integration_webhook" => ToolType.ApiIntegrationWebhook,
                "api_integration_mcp" => ToolType.ApiIntegrationMcp,
                "smb" => ToolType.Smb,
                _ => null,
            };
        }
    }
}