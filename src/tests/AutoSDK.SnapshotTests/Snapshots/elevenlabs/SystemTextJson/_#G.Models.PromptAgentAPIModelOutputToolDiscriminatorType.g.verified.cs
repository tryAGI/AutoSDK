//HintName: G.Models.PromptAgentAPIModelOutputToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAgentAPIModelOutputToolDiscriminatorType
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptAgentAPIModelOutputToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentAPIModelOutputToolDiscriminatorType value)
        {
            return value switch
            {
                PromptAgentAPIModelOutputToolDiscriminatorType.ApiIntegrationWebhook => "api_integration_webhook",
                PromptAgentAPIModelOutputToolDiscriminatorType.Client => "client",
                PromptAgentAPIModelOutputToolDiscriminatorType.Mcp => "mcp",
                PromptAgentAPIModelOutputToolDiscriminatorType.Smb => "smb",
                PromptAgentAPIModelOutputToolDiscriminatorType.System => "system",
                PromptAgentAPIModelOutputToolDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentAPIModelOutputToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_webhook" => PromptAgentAPIModelOutputToolDiscriminatorType.ApiIntegrationWebhook,
                "client" => PromptAgentAPIModelOutputToolDiscriminatorType.Client,
                "mcp" => PromptAgentAPIModelOutputToolDiscriminatorType.Mcp,
                "smb" => PromptAgentAPIModelOutputToolDiscriminatorType.Smb,
                "system" => PromptAgentAPIModelOutputToolDiscriminatorType.System,
                "webhook" => PromptAgentAPIModelOutputToolDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}