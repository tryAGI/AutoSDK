//HintName: G.Models.GetReportScoreResponseScoreDetailsVariant2Column.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetReportScoreResponseScoreDetailsVariant2Column
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_name")]
        public string? ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_type")]
        public string? ScoreType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_skipped")]
        public int? NumSkipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportScoreResponseScoreDetailsVariant2Column" /> class.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="score"></param>
        /// <param name="scoreType"></param>
        /// <param name="numSkipped"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetReportScoreResponseScoreDetailsVariant2Column(
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
        /// Initializes a new instance of the <see cref="GetReportScoreResponseScoreDetailsVariant2Column" /> class.
        /// </summary>
        public GetReportScoreResponseScoreDetailsVariant2Column()
        {
        }
    }
}