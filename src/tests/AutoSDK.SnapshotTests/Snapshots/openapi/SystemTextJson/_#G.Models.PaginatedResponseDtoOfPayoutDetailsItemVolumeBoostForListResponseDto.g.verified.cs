//HintName: G.Models.PaginatedResponseDtoOfPayoutDetailsItemVolumeBoostForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedResponseDtoOfPayoutDetailsItemVolumeBoostForListResponseDto
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
        public global::System.Collections.Generic.IList<global::G.PayoutDetailsItemVolumeBoostForListResponseDto>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedResponseDtoOfPayoutDetailsItemVolumeBoostForListResponseDto" /> class.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedResponseDtoOfPayoutDetailsItemVolumeBoostForListResponseDto(
            int? pageNumber,
            int? pageSize,
            int? count,
            global::System.Collections.Generic.IList<global::G.PayoutDetailsItemVolumeBoostForListResponseDto>? items)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Count = count;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedResponseDtoOfPayoutDetailsItemVolumeBoostForListResponseDto" /> class.
        /// </summary>
        public PaginatedResponseDtoOfPayoutDetailsItemVolumeBoostForListResponseDto()
        {
        }
    }
}