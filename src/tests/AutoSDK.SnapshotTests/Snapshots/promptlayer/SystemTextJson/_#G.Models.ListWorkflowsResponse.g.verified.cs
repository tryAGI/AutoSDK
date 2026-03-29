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
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ListWorkflowsResponseItem> Items { get; set; }

        /// <summary>
        /// Current page number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Number of items per page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PerPage { get; set; }

        /// <summary>
        /// Total number of items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Total number of pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Pages { get; set; }

        /// <summary>
        /// Whether there is a next page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNext { get; set; }

        /// <summary>
        /// Whether there is a previous page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_prev")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPrev { get; set; }

        /// <summary>
        /// Next page number if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_num")]
        public int? NextNum { get; set; }

        /// <summary>
        /// Previous page number if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_num")]
        public int? PrevNum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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