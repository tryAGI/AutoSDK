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
        /// The ID of the output item that the file search call is initiated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that the file search call is initiated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The type of the event. Always `response.file_search_call.completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter))]
        public global::G.ResponseFileSearchCallCompletedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFileSearchCallCompletedEvent" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The ID of the output item that the file search call is initiated.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the file search call is initiated.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.file_search_call.completed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFileSearchCallCompletedEvent(
            string itemId,
            int outputIndex,
            global::G.ResponseFileSearchCallCompletedEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
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