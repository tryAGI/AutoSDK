//HintName: G.Models.ResponseImageGenCallInProgressEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when an image generation tool call is in progress.
    /// </summary>
    public sealed partial class ResponseImageGenCallInProgressEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.image_generation_call.in_progress'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseImageGenCallInProgressEventType Type { get; set; }

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the image generation item being processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The sequence number of the image generation item being processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseImageGenCallInProgressEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.image_generation_call.in_progress'.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the image generation item being processed.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of the image generation item being processed.
        /// </param>
        public ResponseImageGenCallInProgressEvent(
            int outputIndex,
            string itemId,
            int sequenceNumber,
            global::G.ResponseImageGenCallInProgressEventType type)
        {
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseImageGenCallInProgressEvent" /> class.
        /// </summary>
        public ResponseImageGenCallInProgressEvent()
        {
        }
    }
}