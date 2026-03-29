//HintName: G.Models.PipelinesCreatePipelineRequestIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesCreatePipelineRequestIntegrationType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomWebhook,
        /// <summary>
        /// 
        /// </summary>
        Discord,
        /// <summary>
        /// 
        /// </summary>
        MicrosoftTeams,
        /// <summary>
        /// 
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesCreatePipelineRequestIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesCreatePipelineRequestIntegrationType value)
        {
            return value switch
            {
                PipelinesCreatePipelineRequestIntegrationType.CustomWebhook => "custom_webhook",
                PipelinesCreatePipelineRequestIntegrationType.Discord => "discord",
                PipelinesCreatePipelineRequestIntegrationType.MicrosoftTeams => "microsoftTeams",
                PipelinesCreatePipelineRequestIntegrationType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesCreatePipelineRequestIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesCreatePipelineRequestIntegrationType.CustomWebhook,
                "discord" => PipelinesCreatePipelineRequestIntegrationType.Discord,
                "microsoftTeams" => PipelinesCreatePipelineRequestIntegrationType.MicrosoftTeams,
                "slack" => PipelinesCreatePipelineRequestIntegrationType.Slack,
                _ => null,
            };
        }
    }
}