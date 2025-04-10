//HintName: G.Models.RankSummaryItemDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankSummaryItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankLevel")]
        public long? RankLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highestRankLevel")]
        public long? HighestRankLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankName")]
        public string? RankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weakVolumeRequired")]
        public double? WeakVolumeRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strongVolumeRequired")]
        public double? StrongVolumeRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentVolumeWeak")]
        public double? CurrentVolumeWeak { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentVolumeStrong")]
        public double? CurrentVolumeStrong { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referralRankRequiredQuantity")]
        public int? ReferralRankRequiredQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referralRankName")]
        public string? ReferralRankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referralRankQuantityLeft")]
        public int? ReferralRankQuantityLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referralRankQuantityRight")]
        public int? ReferralRankQuantityRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeRemainingWeak")]
        public double? VolumeRemainingWeak { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeRemainingStrong")]
        public double? VolumeRemainingStrong { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achieved")]
        public bool? Achieved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLegReferralRanks")]
        public string? LeftLegReferralRanks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLegReferralRanks")]
        public string? RightLegReferralRanks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLegReferralRanksCompleted")]
        public bool? LeftLegReferralRanksCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLegReferralRanksCompleted")]
        public bool? RightLegReferralRanksCompleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankSummaryItemDto" /> class.
        /// </summary>
        /// <param name="rankLevel"></param>
        /// <param name="highestRankLevel"></param>
        /// <param name="rankName"></param>
        /// <param name="weakVolumeRequired"></param>
        /// <param name="strongVolumeRequired"></param>
        /// <param name="currentVolumeWeak"></param>
        /// <param name="currentVolumeStrong"></param>
        /// <param name="referralRankRequiredQuantity"></param>
        /// <param name="referralRankName"></param>
        /// <param name="referralRankQuantityLeft"></param>
        /// <param name="referralRankQuantityRight"></param>
        /// <param name="volumeRemainingWeak"></param>
        /// <param name="volumeRemainingStrong"></param>
        /// <param name="achieved"></param>
        /// <param name="leftLegReferralRanks"></param>
        /// <param name="rightLegReferralRanks"></param>
        /// <param name="leftLegReferralRanksCompleted"></param>
        /// <param name="rightLegReferralRanksCompleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankSummaryItemDto(
            long? rankLevel,
            long? highestRankLevel,
            string? rankName,
            double? weakVolumeRequired,
            double? strongVolumeRequired,
            double? currentVolumeWeak,
            double? currentVolumeStrong,
            int? referralRankRequiredQuantity,
            string? referralRankName,
            int? referralRankQuantityLeft,
            int? referralRankQuantityRight,
            double? volumeRemainingWeak,
            double? volumeRemainingStrong,
            bool? achieved,
            string? leftLegReferralRanks,
            string? rightLegReferralRanks,
            bool? leftLegReferralRanksCompleted,
            bool? rightLegReferralRanksCompleted)
        {
            this.RankLevel = rankLevel;
            this.HighestRankLevel = highestRankLevel;
            this.RankName = rankName;
            this.WeakVolumeRequired = weakVolumeRequired;
            this.StrongVolumeRequired = strongVolumeRequired;
            this.CurrentVolumeWeak = currentVolumeWeak;
            this.CurrentVolumeStrong = currentVolumeStrong;
            this.ReferralRankRequiredQuantity = referralRankRequiredQuantity;
            this.ReferralRankName = referralRankName;
            this.ReferralRankQuantityLeft = referralRankQuantityLeft;
            this.ReferralRankQuantityRight = referralRankQuantityRight;
            this.VolumeRemainingWeak = volumeRemainingWeak;
            this.VolumeRemainingStrong = volumeRemainingStrong;
            this.Achieved = achieved;
            this.LeftLegReferralRanks = leftLegReferralRanks;
            this.RightLegReferralRanks = rightLegReferralRanks;
            this.LeftLegReferralRanksCompleted = leftLegReferralRanksCompleted;
            this.RightLegReferralRanksCompleted = rightLegReferralRanksCompleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankSummaryItemDto" /> class.
        /// </summary>
        public RankSummaryItemDto()
        {
        }
    }
}