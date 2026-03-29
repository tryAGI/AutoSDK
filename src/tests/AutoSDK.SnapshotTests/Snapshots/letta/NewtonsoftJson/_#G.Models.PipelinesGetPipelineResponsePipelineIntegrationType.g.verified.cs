//HintName: G.Models.PipelinesGetPipelineResponsePipelineIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesGetPipelineResponsePipelineIntegrationType
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
    public static class PipelinesGetPipelineResponsePipelineIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesGetPipelineResponsePipelineIntegrationType value)
        {
            return value switch
            {
                PipelinesGetPipelineResponsePipelineIntegrationType.CustomWebhook => "custom_webhook",
                PipelinesGetPipelineResponsePipelineIntegrationType.Discord => "discord",
                PipelinesGetPipelineResponsePipelineIntegrationType.MicrosoftTeams => "microsoftTeams",
                PipelinesGetPipelineResponsePipelineIntegrationType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesGetPipelineResponsePipelineIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesGetPipelineResponsePipelineIntegrationType.CustomWebhook,
                "discord" => PipelinesGetPipelineResponsePipelineIntegrationType.Discord,
                "microsoftTeams" => PipelinesGetPipelineResponsePipelineIntegrationType.MicrosoftTeams,
                "slack" => PipelinesGetPipelineResponsePipelineIntegrationType.Slack,
                _ => null,
            };
        }
    }
}