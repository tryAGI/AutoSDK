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
        public ReposCreateWebhookRequestConfig? Config { get; set; }

        /// <summary>
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for.
        /// <br/>Default Value: [push]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string?>? Events { get; set; }

        /// <summary>
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.
        /// <br/>Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool Active { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}