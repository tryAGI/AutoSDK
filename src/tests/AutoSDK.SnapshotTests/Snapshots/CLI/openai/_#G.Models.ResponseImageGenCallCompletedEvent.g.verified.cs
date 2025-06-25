//HintName: G.Models.ResponseImageGenCallCompletedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when an image generation tool call has completed and the final image is available.
    /// </summary>
    public sealed partial class ResponseImageGenCallCompletedEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.image_generation_call.completed'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseImageGenCallCompletedEventTypeJsonConverter))]
        public global::G.ResponseImageGenCallCompletedEventType Type { get; set; }

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The unique identifier of the image generation item being processed.
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
        /// Initializes a new instance of the <see cref="ResponseImageGenCallCompletedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.image_generation_call.completed'.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the image generation item being processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseImageGenCallCompletedEvent(
            int outputIndex,
            int sequenceNumber,
            string itemId,
            global::G.ResponseImageGenCallCompletedEventType type)
        {
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseImageGenCallCompletedEvent" /> class.
        /// </summary>
        public ResponseImageGenCallCompletedEvent()
        {
        }
    }
}