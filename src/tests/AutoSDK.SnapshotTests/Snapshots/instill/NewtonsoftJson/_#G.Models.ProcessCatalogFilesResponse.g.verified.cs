//HintName: G.Models.ProcessCatalogFilesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessCatalogFilesResponse
    {
        /// <summary>
        /// The file uid.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.IList<global::G.File>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}