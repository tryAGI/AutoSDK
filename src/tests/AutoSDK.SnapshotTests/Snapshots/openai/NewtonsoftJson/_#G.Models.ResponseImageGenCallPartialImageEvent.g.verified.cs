//HintName: G.Models.ResponseImageGenCallPartialImageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a partial image is available during image generation streaming.
    /// </summary>
    public sealed partial class ResponseImageGenCallPartialImageEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.image_generation_call.partial_image'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseImageGenCallPartialImageEventType Type { get; set; }

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
        /// 0-based index for the partial image (backend is 1-based, but this is 0-based for the user).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partial_image_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int PartialImageIndex { get; set; } = default!;

        /// <summary>
        /// Base64-encoded partial image data, suitable for rendering as an image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partial_image_b64", Required = global::Newtonsoft.Json.Required.Always)]
        public string PartialImageB64 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseImageGenCallPartialImageEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.image_generation_call.partial_image'.
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
        /// <param name="partialImageIndex">
        /// 0-based index for the partial image (backend is 1-based, but this is 0-based for the user).
        /// </param>
        /// <param name="partialImageB64">
        /// Base64-encoded partial image data, suitable for rendering as an image.
        /// </param>
        public ResponseImageGenCallPartialImageEvent(
            int outputIndex,
            string itemId,
            int sequenceNumber,
            int partialImageIndex,
            string partialImageB64,
            global::G.ResponseImageGenCallPartialImageEventType type)
        {
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.SequenceNumber = sequenceNumber;
            this.PartialImageIndex = partialImageIndex;
            this.PartialImageB64 = partialImageB64 ?? throw new global::System.ArgumentNullException(nameof(partialImageB64));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseImageGenCallPartialImageEvent" /> class.
        /// </summary>
        public ResponseImageGenCallPartialImageEvent()
        {
        }
    }
}