//HintName: G.Models.UpdateSlackWebhookCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSlackWebhookCredentialDTO
    {
        /// <summary>
        /// Slack incoming webhook URL. See https://api.slack.com/messaging/webhooks for setup instructions. This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSlackWebhookCredentialDTO" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// Slack incoming webhook URL. See https://api.slack.com/messaging/webhooks for setup instructions. This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSlackWebhookCredentialDTO(
            string? webhookUrl,
            string? name)
        {
            this.WebhookUrl = webhookUrl;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSlackWebhookCredentialDTO" /> class.
        /// </summary>
        public UpdateSlackWebhookCredentialDTO()
        {
        }
    }
}