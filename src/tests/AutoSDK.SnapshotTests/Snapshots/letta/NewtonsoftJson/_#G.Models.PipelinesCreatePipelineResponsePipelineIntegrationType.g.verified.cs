//HintName: G.Models.PipelinesCreatePipelineResponsePipelineIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesCreatePipelineResponsePipelineIntegrationType
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