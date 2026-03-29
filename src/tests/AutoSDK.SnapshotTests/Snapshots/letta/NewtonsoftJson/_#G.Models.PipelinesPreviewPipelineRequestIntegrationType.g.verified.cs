//HintName: G.Models.PipelinesPreviewPipelineRequestIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesPreviewPipelineRequestIntegrationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom_webhook")]
        CustomWebhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discord")]
        Discord,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="microsoftTeams")]
        MicrosoftTeams,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack")]
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesPreviewPipelineRequestIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesPreviewPipelineRequestIntegrationType value)
        {
            return value switch
            {
                PipelinesPreviewPipelineRequestIntegrationType.CustomWebhook => "custom_webhook",
                PipelinesPreviewPipelineRequestIntegrationType.Discord => "discord",
                PipelinesPreviewPipelineRequestIntegrationType.MicrosoftTeams => "microsoftTeams",
                PipelinesPreviewPipelineRequestIntegrationType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesPreviewPipelineRequestIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesPreviewPipelineRequestIntegrationType.CustomWebhook,
                "discord" => PipelinesPreviewPipelineRequestIntegrationType.Discord,
                "microsoftTeams" => PipelinesPreviewPipelineRequestIntegrationType.MicrosoftTeams,
                "slack" => PipelinesPreviewPipelineRequestIntegrationType.Slack,
                _ => null,
            };
        }
    }
}