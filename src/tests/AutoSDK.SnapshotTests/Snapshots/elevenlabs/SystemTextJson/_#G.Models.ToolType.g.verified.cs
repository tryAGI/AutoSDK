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
        ApiIntegrationMcp,
        /// <summary>
        /// 
        /// </summary>
        ApiIntegrationWebhook,
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
        Smb,
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
        Workflow,
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
                ToolType.ApiIntegrationMcp => "api_integration_mcp",
                ToolType.ApiIntegrationWebhook => "api_integration_webhook",
                ToolType.Client => "client",
                ToolType.Mcp => "mcp",
                ToolType.Smb => "smb",
                ToolType.System => "system",
                ToolType.Webhook => "webhook",
                ToolType.Workflow => "workflow",
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
                "api_integration_mcp" => ToolType.ApiIntegrationMcp,
                "api_integration_webhook" => ToolType.ApiIntegrationWebhook,
                "client" => ToolType.Client,
                "mcp" => ToolType.Mcp,
                "smb" => ToolType.Smb,
                "system" => ToolType.System,
                "webhook" => ToolType.Webhook,
                "workflow" => ToolType.Workflow,
                _ => null,
            };
        }
    }
}