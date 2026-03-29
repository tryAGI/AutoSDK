//HintName: G.Models.EvaluatorStatsTimeSeriesDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorStatsTimeSeriesDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorStatsTimeSeriesDataItem" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="date"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorStatsTimeSeriesDataItem(
            double value,
            string date)
        {
            this.Value = value;
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorStatsTimeSeriesDataItem" /> class.
        /// </summary>
        public EvaluatorStatsTimeSeriesDataItem()
        {
        }
    }
}