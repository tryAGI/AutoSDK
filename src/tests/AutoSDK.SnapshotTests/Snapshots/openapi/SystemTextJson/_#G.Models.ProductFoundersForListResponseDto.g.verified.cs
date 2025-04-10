//HintName: G.Models.ProductFoundersForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductFoundersForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDateTime")]
        public global::System.DateTime? StartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDateTime")]
        public global::System.DateTime? EndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issueSize")]
        public int? IssueSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalFoundersQuantityPurchased")]
        public int? TotalFoundersQuantityPurchased { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestPurchaseDate")]
        public global::System.DateTime? LatestPurchaseDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIsFounder")]
        public bool? UserIsFounder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userRegionInFoundersRegion")]
        public bool? UserRegionInFoundersRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFoundersForListResponseDto" /> class.
        /// </summary>
        /// <param name="startDateTime"></param>
        /// <param name="endDateTime"></param>
        /// <param name="issueSize"></param>
        /// <param name="totalFoundersQuantityPurchased"></param>
        /// <param name="latestPurchaseDate"></param>
        /// <param name="userIsFounder"></param>
        /// <param name="userRegionInFoundersRegion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductFoundersForListResponseDto(
            global::System.DateTime? startDateTime,
            global::System.DateTime? endDateTime,
            int? issueSize,
            int? totalFoundersQuantityPurchased,
            global::System.DateTime? latestPurchaseDate,
            bool? userIsFounder,
            bool? userRegionInFoundersRegion)
        {
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.IssueSize = issueSize;
            this.TotalFoundersQuantityPurchased = totalFoundersQuantityPurchased;
            this.LatestPurchaseDate = latestPurchaseDate;
            this.UserIsFounder = userIsFounder;
            this.UserRegionInFoundersRegion = userRegionInFoundersRegion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFoundersForListResponseDto" /> class.
        /// </summary>
        public ProductFoundersForListResponseDto()
        {
        }
    }
}