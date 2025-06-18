//HintName: G.Models.ResponseFileSearchCallCompletedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a file search call is completed (results found).
    /// </summary>
    public sealed partial class ResponseFileSearchCallCompletedEvent
    {
        /// <summary>
        /// The type of the event. Always `response.file_search_call.completed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseFileSearchCallCompletedEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that the file search call is initiated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The ID of the output item that the file search call is initiated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ResponseFileSearchCallCompletedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.file_search_call.completed`.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the file search call is initiated.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the file search call is initiated.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseFileSearchCallCompletedEvent(
            int outputIndex,
            string itemId,
            int sequenceNumber,
            global::G.ResponseFileSearchCallCompletedEventType type)
        {
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFileSearchCallCompletedEvent" /> class.
        /// </summary>
        public ResponseFileSearchCallCompletedEvent()
        {
        }
    }
}