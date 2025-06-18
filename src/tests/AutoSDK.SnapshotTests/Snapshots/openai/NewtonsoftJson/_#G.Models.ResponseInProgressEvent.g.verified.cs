//HintName: G.Models.ResponseInProgressEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the response is in progress.
    /// </summary>
    public sealed partial class ResponseInProgressEvent
    {
        /// <summary>
        /// The type of the event. Always `response.in_progress`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseInProgressEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Response Response { get; set; } = default!;

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInProgressEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.in_progress`.
        /// </param>
        /// <param name="response"></param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseInProgressEvent(
            global::G.Response response,
            int sequenceNumber,
            global::G.ResponseInProgressEventType type)
        {
            this.Response = response;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInProgressEvent" /> class.
        /// </summary>
        public ResponseInProgressEvent()
        {
        }
    }
}