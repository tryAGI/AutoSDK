//HintName: G.Models.XteraValuesForDashboardResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class XteraValuesForDashboardResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyProfit")]
        public double? DailyProfit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousDayProfit")]
        public double? PreviousDayProfit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalProfit")]
        public double? TotalProfit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalValue")]
        public double? TotalValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("myShares")]
        public double? MyShares { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XteraValuesForDashboardResponseDto" /> class.
        /// </summary>
        /// <param name="dailyProfit"></param>
        /// <param name="previousDayProfit"></param>
        /// <param name="totalProfit"></param>
        /// <param name="totalValue"></param>
        /// <param name="myShares"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XteraValuesForDashboardResponseDto(
            double? dailyProfit,
            double? previousDayProfit,
            double? totalProfit,
            double? totalValue,
            double? myShares)
        {
            this.DailyProfit = dailyProfit;
            this.PreviousDayProfit = previousDayProfit;
            this.TotalProfit = totalProfit;
            this.TotalValue = totalValue;
            this.MyShares = myShares;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XteraValuesForDashboardResponseDto" /> class.
        /// </summary>
        public XteraValuesForDashboardResponseDto()
        {
        }
    }
}