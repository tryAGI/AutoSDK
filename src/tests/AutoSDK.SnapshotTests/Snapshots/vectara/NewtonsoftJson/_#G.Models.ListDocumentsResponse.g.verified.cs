//HintName: G.Models.ListDocumentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListDocumentsResponse
    {
        /// <summary>
        /// List of documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<global::G.Document>? Documents { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}