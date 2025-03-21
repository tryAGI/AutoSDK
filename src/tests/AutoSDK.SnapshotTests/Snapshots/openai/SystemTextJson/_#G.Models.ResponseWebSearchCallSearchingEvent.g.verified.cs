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
        /// The type of the event. Always `response.web_search_call.searching`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter))]
        public global::G.ResponseWebSearchCallSearchingEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that the web search call is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// Unique ID for the output item associated with the web search call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebSearchCallSearchingEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.web_search_call.searching`.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the web search call is associated with.
        /// </param>
        /// <param name="itemId">
        /// Unique ID for the output item associated with the web search call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseWebSearchCallSearchingEvent(
            int outputIndex,
            string itemId,
            global::G.ResponseWebSearchCallSearchingEventType type)
        {
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
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