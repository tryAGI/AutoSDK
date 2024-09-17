//HintName: G.Models.ListCatalogFilesFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCatalogFilesFilter
    {
        /// <summary>
        /// The file uids.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUids")]
        public global::System.Collections.Generic.IList<string>? FileUids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}