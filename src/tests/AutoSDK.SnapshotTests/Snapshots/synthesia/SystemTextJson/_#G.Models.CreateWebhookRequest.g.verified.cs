//HintName: G.Models.CreateWebhookRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebhookRequest
    {
        /// <summary>
        /// [The webhook events](https://docs.synthesia.io/reference/webhook-events) for which notifications should be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateWebhookRequestEvent> Events { get; set; }

        /// <summary>
        /// The URL to send notifications to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        /// <param name="events">
        /// [The webhook events](https://docs.synthesia.io/reference/webhook-events) for which notifications should be sent.
        /// </param>
        /// <param name="url">
        /// The URL to send notifications to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebhookRequest(
            global::System.Collections.Generic.IList<global::G.CreateWebhookRequestEvent> events,
            string url)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        public CreateWebhookRequest()
        {
        }
    }
}