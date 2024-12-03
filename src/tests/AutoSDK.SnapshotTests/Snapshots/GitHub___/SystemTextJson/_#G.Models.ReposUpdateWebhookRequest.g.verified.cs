//HintName: G.Models.ReposUpdateWebhookRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateWebhookRequest
    {
        /// <summary>
        /// Configuration object of the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.WebhookConfig? Config { get; set; }

        /// <summary>
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. This replaces the entire array of events.<br/>
        /// Default Value: [push]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Determines a list of events to be added to the list of events that the Hook triggers for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_events")]
        public global::System.Collections.Generic.IList<string>? AddEvents { get; set; }

        /// <summary>
        /// Determines a list of events to be removed from the list of events that the Hook triggers for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_events")]
        public global::System.Collections.Generic.IList<string>? RemoveEvents { get; set; }

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
        /// Initializes a new instance of the <see cref="ReposUpdateWebhookRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Configuration object of the webhook
        /// </param>
        /// <param name="events">
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. This replaces the entire array of events.<br/>
        /// Default Value: [push]
        /// </param>
        /// <param name="addEvents">
        /// Determines a list of events to be added to the list of events that the Hook triggers for.
        /// </param>
        /// <param name="removeEvents">
        /// Determines a list of events to be removed from the list of events that the Hook triggers for.
        /// </param>
        /// <param name="active">
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.<br/>
        /// Default Value: true
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposUpdateWebhookRequest(
            global::G.WebhookConfig? config,
            global::System.Collections.Generic.IList<string>? events,
            global::System.Collections.Generic.IList<string>? addEvents,
            global::System.Collections.Generic.IList<string>? removeEvents,
            bool? active)
        {
            this.Config = config;
            this.Events = events;
            this.AddEvents = addEvents;
            this.RemoveEvents = removeEvents;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateWebhookRequest" /> class.
        /// </summary>
        public ReposUpdateWebhookRequest()
        {
        }
    }
}