//HintName: G.Models.GetReportScoreResponseScoreDetailsVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Single column score details
    /// </summary>
    public sealed partial class GetReportScoreResponseScoreDetailsVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_name")]
        public string? ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_type")]
        public string? ScoreType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_skipped")]
        public int? NumSkipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportScoreResponseScoreDetailsVariant1" /> class.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="score"></param>
        /// <param name="scoreType"></param>
        /// <param name="numSkipped"></param>
        public GetReportScoreResponseScoreDetailsVariant1(
            string? columnName,
            double? score,
            string? scoreType,
            int? numSkipped)
        {
            this.ColumnName = columnName;
            this.Score = score;
            this.ScoreType = scoreType;
            this.NumSkipped = numSkipped;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportScoreResponseScoreDetailsVariant1" /> class.
        /// </summary>
        public GetReportScoreResponseScoreDetailsVariant1()
        {
        }
    }
}