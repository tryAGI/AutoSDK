//HintName: G.Models.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType
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
    public static class PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.ApiIntegrationWebhook => "api_integration_webhook",
                PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Client => "client",
                PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Mcp => "mcp",
                PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Smb => "smb",
                PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.System => "system",
                PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_webhook" => PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.ApiIntegrationWebhook,
                "client" => PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Client,
                "mcp" => PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Mcp,
                "smb" => PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Smb,
                "system" => PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.System,
                "webhook" => PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}