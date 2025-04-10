//HintName: G.Models.InfinityBonusPayoutDetailsItemForListByUserIdResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfinityBonusPayoutDetailsItemForListByUserIdResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directBonus")]
        public double? DirectBonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkBonus")]
        public double? NetworkBonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infinityBonus")]
        public double? InfinityBonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leadershipBonus")]
        public double? LeadershipBonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBonus")]
        public double? TotalBonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyBV")]
        public int? DailyBV { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyEarning")]
        public double? DailyEarning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infinityBonusDate")]
        public global::System.DateTime? InfinityBonusDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfinityBonusPayoutDetailsItemForListByUserIdResponseDto" /> class.
        /// </summary>
        /// <param name="directBonus"></param>
        /// <param name="networkBonus"></param>
        /// <param name="infinityBonus"></param>
        /// <param name="leadershipBonus"></param>
        /// <param name="totalBonus"></param>
        /// <param name="dailyBV"></param>
        /// <param name="dailyEarning"></param>
        /// <param name="infinityBonusDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfinityBonusPayoutDetailsItemForListByUserIdResponseDto(
            double? directBonus,
            double? networkBonus,
            double? infinityBonus,
            double? leadershipBonus,
            double? totalBonus,
            int? dailyBV,
            double? dailyEarning,
            global::System.DateTime? infinityBonusDate)
        {
            this.DirectBonus = directBonus;
            this.NetworkBonus = networkBonus;
            this.InfinityBonus = infinityBonus;
            this.LeadershipBonus = leadershipBonus;
            this.TotalBonus = totalBonus;
            this.DailyBV = dailyBV;
            this.DailyEarning = dailyEarning;
            this.InfinityBonusDate = infinityBonusDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfinityBonusPayoutDetailsItemForListByUserIdResponseDto" /> class.
        /// </summary>
        public InfinityBonusPayoutDetailsItemForListByUserIdResponseDto()
        {
        }
    }
}