//HintName: G.Models.ResponseOutputTextAnnotationAddedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when an annotation is added to output text content.
    /// </summary>
    public sealed partial class ResponseOutputTextAnnotationAddedEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.output_text_annotation.added'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseOutputTextAnnotationAddedEventType Type { get; set; }

        /// <summary>
        /// The unique identifier of the item to which the annotation is being added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The index of the content part within the output item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The index of the annotation within the content part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int AnnotationIndex { get; set; } = default!;

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// The annotation object being added. (See annotation schema for details.)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation", Required = global::Newtonsoft.Json.Required.Always)]
        public object Annotation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextAnnotationAddedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.output_text_annotation.added'.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the item to which the annotation is being added.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part within the output item.
        /// </param>
        /// <param name="annotationIndex">
        /// The index of the annotation within the content part.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="annotation">
        /// The annotation object being added. (See annotation schema for details.)
        /// </param>
        public ResponseOutputTextAnnotationAddedEvent(
            string itemId,
            int outputIndex,
            int contentIndex,
            int annotationIndex,
            int sequenceNumber,
            object annotation,
            global::G.ResponseOutputTextAnnotationAddedEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.AnnotationIndex = annotationIndex;
            this.SequenceNumber = sequenceNumber;
            this.Annotation = annotation ?? throw new global::System.ArgumentNullException(nameof(annotation));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextAnnotationAddedEvent" /> class.
        /// </summary>
        public ResponseOutputTextAnnotationAddedEvent()
        {
        }
    }
}