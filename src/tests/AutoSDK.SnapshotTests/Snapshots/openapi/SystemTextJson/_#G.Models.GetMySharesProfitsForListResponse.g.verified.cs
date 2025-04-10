//HintName: G.Models.GetMySharesProfitsForListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMySharesProfitsForListResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyProfit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DailyProfit { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMySharesProfitsForListResponse" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="dailyProfit"></param>
        /// <param name="totalProfit"></param>
        /// <param name="totalValue"></param>
        /// <param name="totalDays"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMySharesProfitsForListResponse(
            global::System.DateTime date,
            double dailyProfit,
            double totalProfit,
            double totalValue,
            double totalDays)
        {
            this.Date = date;
            this.DailyProfit = dailyProfit;
            this.TotalProfit = totalProfit;
            this.TotalValue = totalValue;
            this.TotalDays = totalDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMySharesProfitsForListResponse" /> class.
        /// </summary>
        public GetMySharesProfitsForListResponse()
        {
        }
    }
}