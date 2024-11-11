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

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogFilesFilter" /> class.
        /// </summary>
        /// <param name="fileUids">
        /// The file uids.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListCatalogFilesFilter(
            global::System.Collections.Generic.IList<string>? fileUids)
        {
            this.FileUids = fileUids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogFilesFilter" /> class.
        /// </summary>
        public ListCatalogFilesFilter()
        {
        }
    }
}