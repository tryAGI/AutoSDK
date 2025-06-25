//HintName: G.Models.ListComponentRunsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListComponentRunsResponse is the response message for ListComponentRuns.
    /// </summary>
    public sealed partial class ListComponentRunsResponse
    {
        /// <summary>
        /// The list of component runs.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("componentRuns")]
        public global::System.Collections.Generic.IList<global::G.ComponentRun>? ComponentRuns { get; set; }

        /// <summary>
        /// The total number of component runs matching the request.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

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
        /// Initializes a new instance of the <see cref="ListComponentRunsResponse" /> class.
        /// </summary>
        /// <param name="componentRuns">
        /// The list of component runs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// The total number of component runs matching the request.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListComponentRunsResponse(
            global::System.Collections.Generic.IList<global::G.ComponentRun>? componentRuns,
            int? totalSize,
            int? page,
            int? pageSize)
        {
            this.ComponentRuns = componentRuns;
            this.TotalSize = totalSize;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComponentRunsResponse" /> class.
        /// </summary>
        public ListComponentRunsResponse()
        {
        }
    }
}