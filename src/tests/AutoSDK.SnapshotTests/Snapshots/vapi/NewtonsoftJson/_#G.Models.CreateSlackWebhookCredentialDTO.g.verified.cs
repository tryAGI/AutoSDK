//HintName: G.Models.CreateSlackWebhookCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSlackWebhookCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateSlackWebhookCredentialDTOProviderJsonConverter))]
        public global::G.CreateSlackWebhookCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// Slack incoming webhook URL. See https://api.slack.com/messaging/webhooks for setup instructions. This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhookUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string WebhookUrl { get; set; } = default!;

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSlackWebhookCredentialDTO" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// Slack incoming webhook URL. See https://api.slack.com/messaging/webhooks for setup instructions. This is not returned in the API.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateSlackWebhookCredentialDTO(
            string webhookUrl,
            global::G.CreateSlackWebhookCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSlackWebhookCredentialDTO" /> class.
        /// </summary>
        public CreateSlackWebhookCredentialDTO()
        {
        }
    }
}