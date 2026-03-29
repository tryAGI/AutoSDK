//HintName: G.Models.CursorPaginationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for cursor-based pagination.
    /// </summary>
    public sealed partial class CursorPaginationResponse
    {
        /// <summary>
        /// Contextual direction-aware flag: True if more items exist in the requested pagination direction. For 'after': more items after this page. For 'before': more items before this page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Cursor of the first item in this page. Use for backward pagination. None if page is empty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_cursor")]
        public string? FirstCursor { get; set; }

        /// <summary>
        /// Cursor of the last item in this page. Use for forward pagination. None if page is empty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_cursor")]
        public string? LastCursor { get; set; }

        /// <summary>
        /// Total number of items available across all pages. Only included when include_total=true was requested. Expensive operation - use sparingly.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPaginationResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Contextual direction-aware flag: True if more items exist in the requested pagination direction. For 'after': more items after this page. For 'before': more items before this page.
        /// </param>
        /// <param name="firstCursor">
        /// Cursor of the first item in this page. Use for backward pagination. None if page is empty.
        /// </param>
        /// <param name="lastCursor">
        /// Cursor of the last item in this page. Use for forward pagination. None if page is empty.
        /// </param>
        /// <param name="total">
        /// Total number of items available across all pages. Only included when include_total=true was requested. Expensive operation - use sparingly.
        /// </param>
        public CursorPaginationResponse(
            bool hasMore,
            string? firstCursor,
            string? lastCursor,
            int? total)
        {
            this.HasMore = hasMore;
            this.FirstCursor = firstCursor;
            this.LastCursor = lastCursor;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPaginationResponse" /> class.
        /// </summary>
        public CursorPaginationResponse()
        {
        }
    }
}