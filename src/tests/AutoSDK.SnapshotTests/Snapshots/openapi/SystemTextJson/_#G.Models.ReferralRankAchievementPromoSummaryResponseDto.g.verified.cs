//HintName: G.Models.ReferralRankAchievementPromoSummaryResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferralRankAchievementPromoSummaryResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiredRankId")]
        public int? RequiredRankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiredRankName")]
        public string? RequiredRankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directReferralsCount")]
        public int? DirectReferralsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directReferralsWithRequiredRankCount")]
        public int? DirectReferralsWithRequiredRankCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralRankAchievementPromoSummaryResponseDto" /> class.
        /// </summary>
        /// <param name="requiredRankId"></param>
        /// <param name="requiredRankName"></param>
        /// <param name="directReferralsCount"></param>
        /// <param name="directReferralsWithRequiredRankCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferralRankAchievementPromoSummaryResponseDto(
            int? requiredRankId,
            string? requiredRankName,
            int? directReferralsCount,
            int? directReferralsWithRequiredRankCount)
        {
            this.RequiredRankId = requiredRankId;
            this.RequiredRankName = requiredRankName;
            this.DirectReferralsCount = directReferralsCount;
            this.DirectReferralsWithRequiredRankCount = directReferralsWithRequiredRankCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralRankAchievementPromoSummaryResponseDto" /> class.
        /// </summary>
        public ReferralRankAchievementPromoSummaryResponseDto()
        {
        }
    }
}