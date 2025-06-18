//HintName: G.Models.ResponseQueuedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a response is queued and waiting to be processed.
    /// </summary>
    public sealed partial class ResponseQueuedEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.queued'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseQueuedEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Response Response { get; set; } = default!;

        /// <summary>
        /// The sequence number for this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseQueuedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.queued'.
        /// </param>
        /// <param name="response"></param>
        /// <param name="sequenceNumber">
        /// The sequence number for this event.
        /// </param>
        public ResponseQueuedEvent(
            global::G.Response response,
            int sequenceNumber,
            global::G.ResponseQueuedEventType type)
        {
            this.Response = response;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseQueuedEvent" /> class.
        /// </summary>
        public ResponseQueuedEvent()
        {
        }
    }
}