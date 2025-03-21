//HintName: G.Models.ResponseTextAnnotationDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a text annotation is added.
    /// </summary>
    public sealed partial class ResponseTextAnnotationDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `response.output_text.annotation.added`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseTextAnnotationDeltaEventType Type { get; set; }

        /// <summary>
        /// The ID of the output item that the text annotation was added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item that the text annotation was added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The index of the content part that the text annotation was added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The index of the annotation that was added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int AnnotationIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Annotation Annotation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextAnnotationDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.output_text.annotation.added`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the text annotation was added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the text annotation was added to.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part that the text annotation was added to.
        /// </param>
        /// <param name="annotationIndex">
        /// The index of the annotation that was added.
        /// </param>
        /// <param name="annotation"></param>
        public ResponseTextAnnotationDeltaEvent(
            string itemId,
            int outputIndex,
            int contentIndex,
            int annotationIndex,
            global::G.Annotation annotation,
            global::G.ResponseTextAnnotationDeltaEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.AnnotationIndex = annotationIndex;
            this.Annotation = annotation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextAnnotationDeltaEvent" /> class.
        /// </summary>
        public ResponseTextAnnotationDeltaEvent()
        {
        }
    }
}