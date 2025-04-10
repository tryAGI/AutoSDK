//HintName: G.Models.PayoutPeriodForCalculateCommissionsRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PayoutPeriodForCalculateCommissionsRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payoutPeriodId")]
        public long? PayoutPeriodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fastWeeklyVolumes")]
        public bool? FastWeeklyVolumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutPeriodForCalculateCommissionsRequestDto" /> class.
        /// </summary>
        /// <param name="payoutPeriodId"></param>
        /// <param name="fastWeeklyVolumes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayoutPeriodForCalculateCommissionsRequestDto(
            long? payoutPeriodId,
            bool? fastWeeklyVolumes)
        {
            this.PayoutPeriodId = payoutPeriodId;
            this.FastWeeklyVolumes = fastWeeklyVolumes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutPeriodForCalculateCommissionsRequestDto" /> class.
        /// </summary>
        public PayoutPeriodForCalculateCommissionsRequestDto()
        {
        }
    }
}