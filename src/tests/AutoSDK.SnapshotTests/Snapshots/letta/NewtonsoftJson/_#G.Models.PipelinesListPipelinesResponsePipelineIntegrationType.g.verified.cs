//HintName: G.Models.PipelinesListPipelinesResponsePipelineIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesListPipelinesResponsePipelineIntegrationType
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
    public static class PipelinesListPipelinesResponsePipelineIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesListPipelinesResponsePipelineIntegrationType value)
        {
            return value switch
            {
                PipelinesListPipelinesResponsePipelineIntegrationType.CustomWebhook => "custom_webhook",
                PipelinesListPipelinesResponsePipelineIntegrationType.Discord => "discord",
                PipelinesListPipelinesResponsePipelineIntegrationType.MicrosoftTeams => "microsoftTeams",
                PipelinesListPipelinesResponsePipelineIntegrationType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesListPipelinesResponsePipelineIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesListPipelinesResponsePipelineIntegrationType.CustomWebhook,
                "discord" => PipelinesListPipelinesResponsePipelineIntegrationType.Discord,
                "microsoftTeams" => PipelinesListPipelinesResponsePipelineIntegrationType.MicrosoftTeams,
                "slack" => PipelinesListPipelinesResponsePipelineIntegrationType.Slack,
                _ => null,
            };
        }
    }
}