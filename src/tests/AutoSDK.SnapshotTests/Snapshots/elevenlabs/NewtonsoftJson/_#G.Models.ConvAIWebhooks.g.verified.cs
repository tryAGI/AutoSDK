//HintName: G.Models.ConvAIWebhooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvAIWebhooks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_call_webhook_id")]
        public string? PostCallWebhookId { get; set; }

        /// <summary>
        /// List of event types to send via webhook. Options: transcript, audio, call_initiation_failure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.WebhookEventType>? Events { get; set; }

        /// <summary>
        /// DEPRECATED: Use 'events' field instead. Whether to send audio data with post-call webhooks for ConvAI conversations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("send_audio")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SendAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWebhooks" /> class.
        /// </summary>
        /// <param name="postCallWebhookId"></param>
        /// <param name="events">
        /// List of event types to send via webhook. Options: transcript, audio, call_initiation_failure.
        /// </param>
        public ConvAIWebhooks(
            string? postCallWebhookId,
            global::System.Collections.Generic.IList<global::G.WebhookEventType>? events)
        {
            this.PostCallWebhookId = postCallWebhookId;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWebhooks" /> class.
        /// </summary>
        public ConvAIWebhooks()
        {
        }
    }
}