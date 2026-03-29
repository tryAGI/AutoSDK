//HintName: G.Models.CreateAgentRequestWebhook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentRequestWebhook
    {
        /// <summary>
        /// URL to receive webhook notifications about agent status changes<br/>
        /// Example: https://example.com/webhooks/cursor-agent
        /// </summary>
        /// <example>https://example.com/webhooks/cursor-agent</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Secret key for webhook payload verification<br/>
        /// Example: your-webhook-secret-key-minimum-32-characters
        /// </summary>
        /// <example>your-webhook-secret-key-minimum-32-characters</example>
        [global::Newtonsoft.Json.JsonProperty("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestWebhook" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to receive webhook notifications about agent status changes<br/>
        /// Example: https://example.com/webhooks/cursor-agent
        /// </param>
        /// <param name="secret">
        /// Secret key for webhook payload verification<br/>
        /// Example: your-webhook-secret-key-minimum-32-characters
        /// </param>
        public CreateAgentRequestWebhook(
            string url,
            string? secret)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestWebhook" /> class.
        /// </summary>
        public CreateAgentRequestWebhook()
        {
        }
    }
}