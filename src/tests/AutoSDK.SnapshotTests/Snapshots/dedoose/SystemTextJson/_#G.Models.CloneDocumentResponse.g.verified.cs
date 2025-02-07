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
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Resource Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerpts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Excerpt> Excerpts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagApps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TrainingTestTagApp> TagApps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDocumentResponse" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="excerpts"></param>
        /// <param name="tagApps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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