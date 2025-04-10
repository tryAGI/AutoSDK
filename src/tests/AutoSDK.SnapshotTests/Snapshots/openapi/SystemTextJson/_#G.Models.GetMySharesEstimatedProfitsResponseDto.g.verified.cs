//HintName: G.Models.GetMySharesEstimatedProfitsResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMySharesEstimatedProfitsResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalEstimatedProfit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalEstimatedProfit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalProjectedValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalProjectedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyBreakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetMySharesEstimatedProfitsMonthlyEarningsDto> MonthlyBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMySharesEstimatedProfitsResponseDto" /> class.
        /// </summary>
        /// <param name="totalEstimatedProfit"></param>
        /// <param name="totalProjectedValue"></param>
        /// <param name="monthlyBreakdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMySharesEstimatedProfitsResponseDto(
            double totalEstimatedProfit,
            double totalProjectedValue,
            global::System.Collections.Generic.IList<global::G.GetMySharesEstimatedProfitsMonthlyEarningsDto> monthlyBreakdown)
        {
            this.TotalEstimatedProfit = totalEstimatedProfit;
            this.TotalProjectedValue = totalProjectedValue;
            this.MonthlyBreakdown = monthlyBreakdown ?? throw new global::System.ArgumentNullException(nameof(monthlyBreakdown));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMySharesEstimatedProfitsResponseDto" /> class.
        /// </summary>
        public GetMySharesEstimatedProfitsResponseDto()
        {
        }
    }
}