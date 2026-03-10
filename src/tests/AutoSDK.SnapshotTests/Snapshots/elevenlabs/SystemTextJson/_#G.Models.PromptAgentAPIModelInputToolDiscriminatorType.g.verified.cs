//HintName: G.Models.PromptAgentAPIModelInputToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAgentAPIModelInputToolDiscriminatorType
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
    public static class PromptAgentAPIModelInputToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentAPIModelInputToolDiscriminatorType value)
        {
            return value switch
            {
                PromptAgentAPIModelInputToolDiscriminatorType.ApiIntegrationWebhook => "api_integration_webhook",
                PromptAgentAPIModelInputToolDiscriminatorType.Client => "client",
                PromptAgentAPIModelInputToolDiscriminatorType.Mcp => "mcp",
                PromptAgentAPIModelInputToolDiscriminatorType.Smb => "smb",
                PromptAgentAPIModelInputToolDiscriminatorType.System => "system",
                PromptAgentAPIModelInputToolDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentAPIModelInputToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_webhook" => PromptAgentAPIModelInputToolDiscriminatorType.ApiIntegrationWebhook,
                "client" => PromptAgentAPIModelInputToolDiscriminatorType.Client,
                "mcp" => PromptAgentAPIModelInputToolDiscriminatorType.Mcp,
                "smb" => PromptAgentAPIModelInputToolDiscriminatorType.Smb,
                "system" => PromptAgentAPIModelInputToolDiscriminatorType.System,
                "webhook" => PromptAgentAPIModelInputToolDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}