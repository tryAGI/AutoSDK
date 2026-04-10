//HintName: G.Models.SlackWebhookCredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlackWebhookCredential
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SlackWebhookCredentialProviderJsonConverter))]
        public global::G.SlackWebhookCredentialProvider Provider { get; set; }

        /// <summary>
        /// Slack incoming webhook URL. See https://api.slack.com/messaging/webhooks for setup instructions. This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhookUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string WebhookUrl { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the credential.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the org that this credential belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="SlackWebhookCredential" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// Slack incoming webhook URL. See https://api.slack.com/messaging/webhooks for setup instructions. This is not returned in the API.
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the credential.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this credential belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public SlackWebhookCredential(
            string webhookUrl,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.SlackWebhookCredentialProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackWebhookCredential" /> class.
        /// </summary>
        public SlackWebhookCredential()
        {
        }
    }
}