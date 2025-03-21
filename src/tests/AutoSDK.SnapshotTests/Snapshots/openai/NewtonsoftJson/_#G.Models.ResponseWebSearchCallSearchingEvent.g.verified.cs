//HintName: G.Models.ResponseWebSearchCallSearchingEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a web search call is executing.
    /// </summary>
    public sealed partial class ResponseWebSearchCallSearchingEvent
    {
        /// <summary>
        /// Unique ID for the output item associated with the web search call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item that the web search call is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The type of the event. Always `response.web_search_call.searching`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseWebSearchCallSearchingEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebSearchCallSearchingEvent" /> class.
        /// </summary>
        /// <param name="itemId">
        /// Unique ID for the output item associated with the web search call.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the web search call is associated with.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.web_search_call.searching`.
        /// </param>
        public ResponseWebSearchCallSearchingEvent(
            string itemId,
            int outputIndex,
            global::G.ResponseWebSearchCallSearchingEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebSearchCallSearchingEvent" /> class.
        /// </summary>
        public ResponseWebSearchCallSearchingEvent()
        {
        }
    }
}