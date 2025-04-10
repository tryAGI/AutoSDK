//HintName: G.Models.PayoutPeriodCommissionPoolSummaryForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PayoutPeriodCommissionPoolSummaryForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commissionPoolName")]
        public string? CommissionPoolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payoutPeriodDescription")]
        public string? PayoutPeriodDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payoutPeriodId")]
        public long? PayoutPeriodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commissionPoolId")]
        public long? CommissionPoolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentageRevenueShare")]
        public double? PercentageRevenueShare { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weeklyVolume")]
        public double? WeeklyVolume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achievers")]
        public int? Achievers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenuePerMember")]
        public double? RevenuePerMember { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutPeriodCommissionPoolSummaryForListResponseDto" /> class.
        /// </summary>
        /// <param name="commissionPoolName"></param>
        /// <param name="payoutPeriodDescription"></param>
        /// <param name="id"></param>
        /// <param name="payoutPeriodId"></param>
        /// <param name="commissionPoolId"></param>
        /// <param name="percentageRevenueShare"></param>
        /// <param name="weeklyVolume"></param>
        /// <param name="achievers"></param>
        /// <param name="revenuePerMember"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayoutPeriodCommissionPoolSummaryForListResponseDto(
            string? commissionPoolName,
            string? payoutPeriodDescription,
            long? id,
            long? payoutPeriodId,
            long? commissionPoolId,
            double? percentageRevenueShare,
            double? weeklyVolume,
            int? achievers,
            double? revenuePerMember)
        {
            this.CommissionPoolName = commissionPoolName;
            this.PayoutPeriodDescription = payoutPeriodDescription;
            this.Id = id;
            this.PayoutPeriodId = payoutPeriodId;
            this.CommissionPoolId = commissionPoolId;
            this.PercentageRevenueShare = percentageRevenueShare;
            this.WeeklyVolume = weeklyVolume;
            this.Achievers = achievers;
            this.RevenuePerMember = revenuePerMember;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutPeriodCommissionPoolSummaryForListResponseDto" /> class.
        /// </summary>
        public PayoutPeriodCommissionPoolSummaryForListResponseDto()
        {
        }
    }
}