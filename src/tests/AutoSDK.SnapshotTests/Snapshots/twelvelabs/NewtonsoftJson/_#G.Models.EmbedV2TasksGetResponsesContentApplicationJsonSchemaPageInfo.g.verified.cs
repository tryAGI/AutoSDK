//HintName: G.Models.EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that provides information about pagination.
    /// </summary>
    public sealed partial class EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo
    {
        /// <summary>
        /// The maximum number of items on each page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit_per_page")]
        public int? LimitPerPage { get; set; }

        /// <summary>
        /// The page you retrieved.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_page")]
        public int? TotalPage { get; set; }

        /// <summary>
        /// The total number of results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_results")]
        public int? TotalResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo" /> class.
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
        public EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo(
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
        /// Initializes a new instance of the <see cref="EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo" /> class.
        /// </summary>
        public EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo()
        {
        }
    }
}