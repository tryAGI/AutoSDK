//HintName: G.Models.WebhookEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// WebhookEndpoint describe a webhook endpoint.
    /// </summary>
    public sealed partial class WebhookEndpoint
    {
        /// <summary>
        /// Webhook URL.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Description.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpoint" /> class.
        /// </summary>
        /// <param name="url">
        /// Webhook URL.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Description.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookEndpoint(
            string? url,
            string? description)
        {
            this.Url = url;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpoint" /> class.
        /// </summary>
        public WebhookEndpoint()
        {
        }
    }
}