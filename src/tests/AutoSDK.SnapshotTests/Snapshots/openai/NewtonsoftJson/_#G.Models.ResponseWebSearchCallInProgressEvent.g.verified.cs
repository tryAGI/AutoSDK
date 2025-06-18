//HintName: G.Models.ResponseWebSearchCallInProgressEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a web search call is initiated.
    /// </summary>
    public sealed partial class ResponseWebSearchCallInProgressEvent
    {
        /// <summary>
        /// The type of the event. Always `response.web_search_call.in_progress`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseWebSearchCallInProgressEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that the web search call is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// Unique ID for the output item associated with the web search call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The sequence number of the web search call being processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebSearchCallInProgressEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.web_search_call.in_progress`.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the web search call is associated with.
        /// </param>
        /// <param name="itemId">
        /// Unique ID for the output item associated with the web search call.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of the web search call being processed.
        /// </param>
        public ResponseWebSearchCallInProgressEvent(
            int outputIndex,
            string itemId,
            int sequenceNumber,
            global::G.ResponseWebSearchCallInProgressEventType type)
        {
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebSearchCallInProgressEvent" /> class.
        /// </summary>
        public ResponseWebSearchCallInProgressEvent()
        {
        }
    }
}