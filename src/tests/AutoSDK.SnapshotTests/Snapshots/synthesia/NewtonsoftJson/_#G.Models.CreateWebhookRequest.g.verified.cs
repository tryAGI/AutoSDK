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
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateWebhookRequestEvent> Events { get; set; } = default!;

        /// <summary>
        /// The URL to send notifications to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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