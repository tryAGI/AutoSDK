//HintName: G.Models.PaginatedResponseDtoOfProductSubscriptionCharityBadgesForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedResponseDtoOfProductSubscriptionCharityBadgesForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageNumber")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::G.ProductSubscriptionCharityBadgesForListResponseDto>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedResponseDtoOfProductSubscriptionCharityBadgesForListResponseDto" /> class.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedResponseDtoOfProductSubscriptionCharityBadgesForListResponseDto(
            int? pageNumber,
            int? pageSize,
            int? count,
            global::System.Collections.Generic.IList<global::G.ProductSubscriptionCharityBadgesForListResponseDto>? items)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Count = count;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedResponseDtoOfProductSubscriptionCharityBadgesForListResponseDto" /> class.
        /// </summary>
        public PaginatedResponseDtoOfProductSubscriptionCharityBadgesForListResponseDto()
        {
        }
    }
}