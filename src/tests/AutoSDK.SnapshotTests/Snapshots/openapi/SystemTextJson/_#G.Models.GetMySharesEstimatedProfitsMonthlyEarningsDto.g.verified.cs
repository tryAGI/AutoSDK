//HintName: G.Models.GetMySharesEstimatedProfitsMonthlyEarningsDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMySharesEstimatedProfitsMonthlyEarningsDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPartialMonth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPartialMonth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Profit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalProfit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalProfit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMySharesEstimatedProfitsMonthlyEarningsDto" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="isPartialMonth"></param>
        /// <param name="profit"></param>
        /// <param name="totalDays"></param>
        /// <param name="totalProfit"></param>
        /// <param name="totalValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMySharesEstimatedProfitsMonthlyEarningsDto(
            global::System.DateTime date,
            bool isPartialMonth,
            double profit,
            double totalDays,
            double totalProfit,
            double totalValue)
        {
            this.Date = date;
            this.IsPartialMonth = isPartialMonth;
            this.Profit = profit;
            this.TotalDays = totalDays;
            this.TotalProfit = totalProfit;
            this.TotalValue = totalValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMySharesEstimatedProfitsMonthlyEarningsDto" /> class.
        /// </summary>
        public GetMySharesEstimatedProfitsMonthlyEarningsDto()
        {
        }
    }
}