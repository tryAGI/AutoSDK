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
        [global::System.Text.Json.Serialization.JsonPropertyName("post_call_webhook_id")]
        public string? PostCallWebhookId { get; set; }

        /// <summary>
        /// List of event types to send via webhook. Options: transcript, audio, call_initiation_failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::G.WebhookEventType>? Events { get; set; }

        /// <summary>
        /// DEPRECATED: Use 'events' field instead. Whether to send audio data with post-call webhooks for ConvAI conversations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_audio")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SendAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWebhooks" /> class.
        /// </summary>
        /// <param name="postCallWebhookId"></param>
        /// <param name="events">
        /// List of event types to send via webhook. Options: transcript, audio, call_initiation_failure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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