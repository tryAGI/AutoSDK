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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "url_citation";

        /// <summary>
        /// A URL citation when using web search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_citation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnnotationURLCitation UrlCitation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        /// <param name="urlCitation">
        /// A URL citation when using web search.
        /// </param>
        /// <param name="type"></param>
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