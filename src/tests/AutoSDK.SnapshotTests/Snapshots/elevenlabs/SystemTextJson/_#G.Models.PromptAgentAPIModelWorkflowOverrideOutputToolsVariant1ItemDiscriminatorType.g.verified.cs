//HintName: G.Models.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType
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
    public static class PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.ApiIntegrationWebhook => "api_integration_webhook",
                PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Client => "client",
                PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Mcp => "mcp",
                PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Smb => "smb",
                PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.System => "system",
                PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_webhook" => PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.ApiIntegrationWebhook,
                "client" => PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Client,
                "mcp" => PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Mcp,
                "smb" => PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Smb,
                "system" => PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.System,
                "webhook" => PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}