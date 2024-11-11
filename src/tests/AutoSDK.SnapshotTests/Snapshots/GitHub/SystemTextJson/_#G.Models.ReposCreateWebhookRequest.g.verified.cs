//HintName: G.Models.ReposCreateWebhookRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateWebhookRequest
    {
        /// <summary>
        /// Use `web` to create a webhook. Default: `web`. This parameter only accepts the value `web`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Key/value pairs to provide settings for this webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.ReposCreateWebhookRequestConfig? Config { get; set; }

        /// <summary>
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for.<br/>
        /// Default Value: [push]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateWebhookRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Use `web` to create a webhook. Default: `web`. This parameter only accepts the value `web`.
        /// </param>
        /// <param name="config">
        /// Key/value pairs to provide settings for this webhook.
        /// </param>
        /// <param name="events">
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for.<br/>
        /// Default Value: [push]
        /// </param>
        /// <param name="active">
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.<br/>
        /// Default Value: true
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposCreateWebhookRequest(
            string? name,
            global::G.ReposCreateWebhookRequestConfig? config,
            global::System.Collections.Generic.IList<string>? events,
            bool? active)
        {
            this.Name = name;
            this.Config = config;
            this.Events = events;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateWebhookRequest" /> class.
        /// </summary>
        public ReposCreateWebhookRequest()
        {
        }
    }
}