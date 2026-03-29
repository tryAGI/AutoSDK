//HintName: G.Models.PipelinesCreatePipelineResponsePipelineIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesCreatePipelineResponsePipelineIntegrationType
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
    public static class PipelinesCreatePipelineResponsePipelineIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesCreatePipelineResponsePipelineIntegrationType value)
        {
            return value switch
            {
                PipelinesCreatePipelineResponsePipelineIntegrationType.CustomWebhook => "custom_webhook",
                PipelinesCreatePipelineResponsePipelineIntegrationType.Discord => "discord",
                PipelinesCreatePipelineResponsePipelineIntegrationType.MicrosoftTeams => "microsoftTeams",
                PipelinesCreatePipelineResponsePipelineIntegrationType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesCreatePipelineResponsePipelineIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesCreatePipelineResponsePipelineIntegrationType.CustomWebhook,
                "discord" => PipelinesCreatePipelineResponsePipelineIntegrationType.Discord,
                "microsoftTeams" => PipelinesCreatePipelineResponsePipelineIntegrationType.MicrosoftTeams,
                "slack" => PipelinesCreatePipelineResponsePipelineIntegrationType.Slack,
                _ => null,
            };
        }
    }
}