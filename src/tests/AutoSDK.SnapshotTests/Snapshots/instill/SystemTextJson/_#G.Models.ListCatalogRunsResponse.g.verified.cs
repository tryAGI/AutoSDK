//HintName: G.Models.ListCatalogRunsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListCatalogRunsResponse is the response message for ListCatalogRuns.
    /// </summary>
    public sealed partial class ListCatalogRunsResponse
    {
        /// <summary>
        /// The list of runs.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogRuns")]
        public global::System.Collections.Generic.IList<global::G.CatalogRun>? CatalogRuns { get; set; }

        /// <summary>
        /// The total number of runs matching the request.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public string? TotalSize { get; set; }

        /// <summary>
        /// The current page number.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// The number of items per page.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogRunsResponse" /> class.
        /// </summary>
        /// <param name="catalogRuns">
        /// The list of runs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// The total number of runs matching the request.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="page">
        /// The current page number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pageSize">
        /// The number of items per page.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListCatalogRunsResponse(
            global::System.Collections.Generic.IList<global::G.CatalogRun>? catalogRuns,
            string? totalSize,
            int? page,
            int? pageSize)
        {
            this.CatalogRuns = catalogRuns;
            this.TotalSize = totalSize;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogRunsResponse" /> class.
        /// </summary>
        public ListCatalogRunsResponse()
        {
        }
    }
}