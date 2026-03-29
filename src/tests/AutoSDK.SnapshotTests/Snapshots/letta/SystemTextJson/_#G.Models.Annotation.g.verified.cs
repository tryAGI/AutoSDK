//HintName: G.Models.Annotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A URL citation when using web search.
    /// </summary>
    public sealed partial class Annotation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"url_citation"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "url_citation";

        /// <summary>
        /// A URL citation when using web search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnnotationURLCitation UrlCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        /// <param name="urlCitation">
        /// A URL citation when using web search.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Annotation(
            global::G.AnnotationURLCitation urlCitation,
            string type = "url_citation")
        {
            this.Type = type;
            this.UrlCitation = urlCitation ?? throw new global::System.ArgumentNullException(nameof(urlCitation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        public Annotation()
        {
        }
    }
}