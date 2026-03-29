//HintName: G.Models.Annotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An annotation that provides citations or references for content in a message.
    /// </summary>
    public sealed partial class Annotation
    {
        /// <summary>
        /// The type of annotation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnnotationType Type { get; set; } = default!;

        /// <summary>
        /// A citation referencing a specific document that was provided in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_citation")]
        public global::G.DocumentCitation? DocumentCitation { get; set; }

        /// <summary>
        /// A citation referencing the result of a function or tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_citation")]
        public global::G.FunctionCitation? FunctionCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of annotation.
        /// </param>
        /// <param name="documentCitation">
        /// A citation referencing a specific document that was provided in the request.
        /// </param>
        /// <param name="functionCitation">
        /// A citation referencing the result of a function or tool call.
        /// </param>
        public Annotation(
            global::G.AnnotationType type,
            global::G.DocumentCitation? documentCitation,
            global::G.FunctionCitation? functionCitation)
        {
            this.Type = type;
            this.DocumentCitation = documentCitation;
            this.FunctionCitation = functionCitation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        public Annotation()
        {
        }
    }
}