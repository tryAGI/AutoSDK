//HintName: G.Models.CloneDocumentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneDocumentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Resource Document { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerpts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Excerpt> Excerpts { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagApps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TrainingTestTagApp> TagApps { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDocumentResponse" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="excerpts"></param>
        /// <param name="tagApps"></param>
        public CloneDocumentResponse(
            global::G.Resource document,
            global::System.Collections.Generic.IList<global::G.Excerpt> excerpts,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp> tagApps)
        {
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.Excerpts = excerpts ?? throw new global::System.ArgumentNullException(nameof(excerpts));
            this.TagApps = tagApps ?? throw new global::System.ArgumentNullException(nameof(tagApps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDocumentResponse" /> class.
        /// </summary>
        public CloneDocumentResponse()
        {
        }
    }
}