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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseImageGenCallPartialImageEventTypeJsonConverter))]
        public global::G.ResponseImageGenCallPartialImageEventType Type { get; set; }

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The unique identifier of the image generation item being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The sequence number of the image generation item being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// 0-based index for the partial image (backend is 1-based, but this is 0-based for the user).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_image_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartialImageIndex { get; set; }

        /// <summary>
        /// Base64-encoded partial image data, suitable for rendering as an image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_image_b64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartialImageB64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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