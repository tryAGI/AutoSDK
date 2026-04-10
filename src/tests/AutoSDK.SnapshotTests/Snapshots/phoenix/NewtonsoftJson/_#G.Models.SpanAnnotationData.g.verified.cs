//HintName: G.Models.SpanAnnotationData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanAnnotationData
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpanAnnotationDataAnnotatorKindJsonConverter))]
        public global::G.SpanAnnotationDataAnnotatorKind AnnotatorKind { get; set; } = default!;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanAnnotationData" /> class.
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
        /// <param name="result">
        /// The result of the annotation
        /// </param>
        /// <param name="metadata">
        /// Metadata for the annotation
        /// </param>
        /// <param name="identifier">
        /// The identifier of the annotation. If provided, the annotation will be updated if it already exists.
        /// </param>
        public SpanAnnotationData(
            string name,
            global::G.SpanAnnotationDataAnnotatorKind annotatorKind,
            string spanId,
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanAnnotationData" /> class.
        /// </summary>
        public SpanAnnotationData()
        {
        }
    }
}