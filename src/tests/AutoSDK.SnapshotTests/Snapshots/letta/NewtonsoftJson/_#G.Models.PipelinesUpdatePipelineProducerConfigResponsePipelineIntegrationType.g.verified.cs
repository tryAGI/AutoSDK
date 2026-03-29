//HintName: G.Models.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType
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
    public static class PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType value)
        {
            return value switch
            {
                PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType.CustomWebhook => "custom_webhook",
                PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType.Discord => "discord",
                PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType.MicrosoftTeams => "microsoftTeams",
                PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType.CustomWebhook,
                "discord" => PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType.Discord,
                "microsoftTeams" => PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType.MicrosoftTeams,
                "slack" => PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType.Slack,
                _ => null,
            };
        }
    }
}