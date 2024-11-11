//HintName: G.Models.ReposCreateDispatchEventRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateDispatchEventRequest
    {
        /// <summary>
        /// A custom webhook event name. Must be 100 characters or fewer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventType { get; set; } = default!;

        /// <summary>
        /// JSON payload with extra information about the webhook event that your action or workflow may use. The maximum number of top-level properties is 10.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_payload")]
        public object? ClientPayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDispatchEventRequest" /> class.
        /// </summary>
        /// <param name="eventType">
        /// A custom webhook event name. Must be 100 characters or fewer.
        /// </param>
        /// <param name="clientPayload">
        /// JSON payload with extra information about the webhook event that your action or workflow may use. The maximum number of top-level properties is 10.
        /// </param>
        public ReposCreateDispatchEventRequest(
            string eventType,
            object? clientPayload)
        {
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.ClientPayload = clientPayload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDispatchEventRequest" /> class.
        /// </summary>
        public ReposCreateDispatchEventRequest()
        {
        }
    }
}