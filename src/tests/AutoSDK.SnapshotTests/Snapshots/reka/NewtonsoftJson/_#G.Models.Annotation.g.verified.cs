//HintName: G.Models.Annotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation annotation referencing a web source.
    /// </summary>
    public sealed partial class Annotation
    {
        /// <summary>
        /// The annotation type. Always "url_citation".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AnnotationType Type { get; set; }

        /// <summary>
        /// URL citation details with character-level positioning in the response content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_citation")]
        public global::G.UrlCitation? UrlCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        /// <param name="type">
        /// The annotation type. Always "url_citation".
        /// </param>
        /// <param name="urlCitation">
        /// URL citation details with character-level positioning in the response content.
        /// </param>
        public Annotation(
            global::G.AnnotationType type,
            global::G.UrlCitation? urlCitation)
        {
            this.Type = type;
            this.UrlCitation = urlCitation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        public Annotation()
        {
        }
    }
}