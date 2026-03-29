//HintName: G.Models.PaginatedResponseBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedResponseBase
    {
        /// <summary>
        /// Pagination key for the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination_key")]
        public string? PaginationKey { get; set; }

        /// <summary>
        /// Whether more results are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedResponseBase" /> class.
        /// </summary>
        /// <param name="paginationKey">
        /// Pagination key for the next page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more results are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedResponseBase(
            string? paginationKey,
            bool? hasMore)
        {
            this.PaginationKey = paginationKey;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedResponseBase" /> class.
        /// </summary>
        public PaginatedResponseBase()
        {
        }
    }
}