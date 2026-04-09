//HintName: G.Models.SpanDocumentAnnotationData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanDocumentAnnotationData
    {
        /// <summary>
        /// The name of the annotation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The kind of annotator used for the annotation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotator_kind", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindJsonConverter))]
        public global::G.SpanDocumentAnnotationDataAnnotatorKind AnnotatorKind { get; set; } = default!;

        /// <summary>
        /// The result of the annotation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.AnnotationResult? Result { get; set; }

        /// <summary>
        /// Metadata for the annotation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The identifier of the annotation. If provided, the annotation will be updated if it already exists.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// OpenTelemetry Span ID (hex format w/o 0x prefix)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpanId { get; set; } = default!;

        /// <summary>
        /// A 0 based index of the document. E.x. the first document during retrieval is 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_position", Required = global::Newtonsoft.Json.Required.Always)]
        public int DocumentPosition { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanDocumentAnnotationData" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the annotation
        /// </param>
        /// <param name="annotatorKind">
        /// The kind of annotator used for the annotation
        /// </param>
        /// <param name="spanId">
        /// OpenTelemetry Span ID (hex format w/o 0x prefix)
        /// </param>
        /// <param name="documentPosition">
        /// A 0 based index of the document. E.x. the first document during retrieval is 0
        /// </param>
        /// <param name="result">
        /// The result of the annotation
        /// </param>
        /// <param name="metadata">
        /// Metadata for the annotation
        /// </param>
        /// <param name="identifier">
        /// The identifier of the annotation. If provided, the annotation will be updated if it already exists.
        /// </param>
        public SpanDocumentAnnotationData(
            string name,
            global::G.SpanDocumentAnnotationDataAnnotatorKind annotatorKind,
            string spanId,
            int documentPosition,
            global::G.AnnotationResult? result,
            object? metadata,
            string? identifier)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AnnotatorKind = annotatorKind;
            this.Result = result;
            this.Metadata = metadata;
            this.Identifier = identifier;
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.DocumentPosition = documentPosition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanDocumentAnnotationData" /> class.
        /// </summary>
        public SpanDocumentAnnotationData()
        {
        }
    }
}