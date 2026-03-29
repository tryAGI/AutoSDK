//HintName: G.Models.ListWorkflowsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListWorkflowsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ListWorkflowsResponseItem> Items { get; set; } = default!;

        /// <summary>
        /// Current page number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page", Required = global::Newtonsoft.Json.Required.Always)]
        public int Page { get; set; } = default!;

        /// <summary>
        /// Number of items per page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("per_page", Required = global::Newtonsoft.Json.Required.Always)]
        public int PerPage { get; set; } = default!;

        /// <summary>
        /// Total number of items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Total number of pages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages", Required = global::Newtonsoft.Json.Required.Always)]
        public int Pages { get; set; } = default!;

        /// <summary>
        /// Whether there is a next page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_next", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNext { get; set; } = default!;

        /// <summary>
        /// Whether there is a previous page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_prev", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasPrev { get; set; } = default!;

        /// <summary>
        /// Next page number if available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_num")]
        public int? NextNum { get; set; }

        /// <summary>
        /// Previous page number if available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prev_num")]
        public int? PrevNum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkflowsResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="page">
        /// Current page number
        /// </param>
        /// <param name="perPage">
        /// Number of items per page
        /// </param>
        /// <param name="pages">
        /// Total number of pages
        /// </param>
        /// <param name="hasNext">
        /// Whether there is a next page
        /// </param>
        /// <param name="hasPrev">
        /// Whether there is a previous page
        /// </param>
        /// <param name="total">
        /// Total number of items
        /// </param>
        /// <param name="nextNum">
        /// Next page number if available
        /// </param>
        /// <param name="prevNum">
        /// Previous page number if available
        /// </param>
        public ListWorkflowsResponse(
            global::System.Collections.Generic.IList<global::G.ListWorkflowsResponseItem> items,
            int page,
            int perPage,
            int pages,
            bool hasNext,
            bool hasPrev,
            int? total,
            int? nextNum,
            int? prevNum)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Page = page;
            this.PerPage = perPage;
            this.Total = total;
            this.Pages = pages;
            this.HasNext = hasNext;
            this.HasPrev = hasPrev;
            this.NextNum = nextNum;
            this.PrevNum = prevNum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkflowsResponse" /> class.
        /// </summary>
        public ListWorkflowsResponse()
        {
        }
    }
}