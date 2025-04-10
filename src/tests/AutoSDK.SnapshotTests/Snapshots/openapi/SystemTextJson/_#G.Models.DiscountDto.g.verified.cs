//HintName: G.Models.DiscountDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiscountDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long? ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long? RankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? StartAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? EndAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Percentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isActive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountDto" /> class.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="rankId"></param>
        /// <param name="startAt"></param>
        /// <param name="endAt"></param>
        /// <param name="percentage"></param>
        /// <param name="isActive"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscountDto(
            long? productId,
            long? rankId,
            global::System.DateTime? startAt,
            global::System.DateTime? endAt,
            double percentage,
            bool isActive)
        {
            this.ProductId = productId;
            this.RankId = rankId;
            this.StartAt = startAt;
            this.EndAt = endAt;
            this.Percentage = percentage;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountDto" /> class.
        /// </summary>
        public DiscountDto()
        {
        }
    }
}