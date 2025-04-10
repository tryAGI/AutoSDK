//HintName: G.Models.PaginationResponseDtoOfGetMySharesProfitsForListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginationResponseDtoOfGetMySharesProfitsForListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageNumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetMySharesProfitsForListResponse> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponseDtoOfGetMySharesProfitsForListResponse" /> class.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginationResponseDtoOfGetMySharesProfitsForListResponse(
            int pageNumber,
            int pageSize,
            int count,
            global::System.Collections.Generic.IList<global::G.GetMySharesProfitsForListResponse> items)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Count = count;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponseDtoOfGetMySharesProfitsForListResponse" /> class.
        /// </summary>
        public PaginationResponseDtoOfGetMySharesProfitsForListResponse()
        {
        }
    }
}