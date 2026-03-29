//HintName: G.Models.TasksGetResponsesContentApplicationJsonSchemaPageInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that provides information about pagination.
    /// </summary>
    public sealed partial class TasksGetResponsesContentApplicationJsonSchemaPageInfo
    {
        /// <summary>
        /// The maximum number of items on each page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_per_page")]
        public int? LimitPerPage { get; set; }

        /// <summary>
        /// The page you retrieved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_page")]
        public int? TotalPage { get; set; }

        /// <summary>
        /// The total number of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_results")]
        public int? TotalResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksGetResponsesContentApplicationJsonSchemaPageInfo" /> class.
        /// </summary>
        /// <param name="limitPerPage">
        /// The maximum number of items on each page.
        /// </param>
        /// <param name="page">
        /// The page you retrieved.
        /// </param>
        /// <param name="totalPage">
        /// The total number of pages.
        /// </param>
        /// <param name="totalResults">
        /// The total number of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksGetResponsesContentApplicationJsonSchemaPageInfo(
            int? limitPerPage,
            int? page,
            int? totalPage,
            int? totalResults)
        {
            this.LimitPerPage = limitPerPage;
            this.Page = page;
            this.TotalPage = totalPage;
            this.TotalResults = totalResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksGetResponsesContentApplicationJsonSchemaPageInfo" /> class.
        /// </summary>
        public TasksGetResponsesContentApplicationJsonSchemaPageInfo()
        {
        }
    }
}