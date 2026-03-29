//HintName: G.Models.PipelinesUpdatePipelineResponsePipelineIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesUpdatePipelineResponsePipelineIntegrationType
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
    public static class PipelinesUpdatePipelineResponsePipelineIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesUpdatePipelineResponsePipelineIntegrationType value)
        {
            return value switch
            {
                PipelinesUpdatePipelineResponsePipelineIntegrationType.CustomWebhook => "custom_webhook",
                PipelinesUpdatePipelineResponsePipelineIntegrationType.Discord => "discord",
                PipelinesUpdatePipelineResponsePipelineIntegrationType.MicrosoftTeams => "microsoftTeams",
                PipelinesUpdatePipelineResponsePipelineIntegrationType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesUpdatePipelineResponsePipelineIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesUpdatePipelineResponsePipelineIntegrationType.CustomWebhook,
                "discord" => PipelinesUpdatePipelineResponsePipelineIntegrationType.Discord,
                "microsoftTeams" => PipelinesUpdatePipelineResponsePipelineIntegrationType.MicrosoftTeams,
                "slack" => PipelinesUpdatePipelineResponsePipelineIntegrationType.Slack,
                _ => null,
            };
        }
    }
}