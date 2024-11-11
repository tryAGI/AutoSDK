//HintName: G.Models.ResourceServiceCloneDocumentControllerOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceServiceCloneDocumentControllerOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::G.Resource? Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerpts")]
        public global::System.Collections.Generic.IList<global::G.Excerpt>? Excerpts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagApps")]
        public global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>? TagApps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceServiceCloneDocumentControllerOutput" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="excerpts"></param>
        /// <param name="tagApps"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ResourceServiceCloneDocumentControllerOutput(
            global::G.Resource? document,
            global::System.Collections.Generic.IList<global::G.Excerpt>? excerpts,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>? tagApps)
        {
            this.Document = document;
            this.Excerpts = excerpts;
            this.TagApps = tagApps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceServiceCloneDocumentControllerOutput" /> class.
        /// </summary>
        public ResourceServiceCloneDocumentControllerOutput()
        {
        }
    }
}