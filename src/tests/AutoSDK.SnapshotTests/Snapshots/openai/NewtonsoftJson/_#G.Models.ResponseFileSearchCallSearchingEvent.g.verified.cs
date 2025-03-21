//HintName: G.Models.ResponseFileSearchCallSearchingEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a file search is currently searching.
    /// </summary>
    public sealed partial class ResponseFileSearchCallSearchingEvent
    {
        /// <summary>
        /// The ID of the output item that the file search call is initiated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item that the file search call is searching.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The type of the event. Always `response.file_search_call.searching`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseFileSearchCallSearchingEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFileSearchCallSearchingEvent" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The ID of the output item that the file search call is initiated.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the file search call is searching.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.file_search_call.searching`.
        /// </param>
        public ResponseFileSearchCallSearchingEvent(
            string itemId,
            int outputIndex,
            global::G.ResponseFileSearchCallSearchingEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFileSearchCallSearchingEvent" /> class.
        /// </summary>
        public ResponseFileSearchCallSearchingEvent()
        {
        }
    }
}