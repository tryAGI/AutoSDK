//HintName: G.Models.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_trunc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAtTrunc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_sum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScoreSum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScoreKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem" /> class.
        /// </summary>
        /// <param name="createdAtTrunc"></param>
        /// <param name="scoreSum"></param>
        /// <param name="scoreKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem(
            string createdAtTrunc,
            double scoreSum,
            string scoreKey)
        {
            this.CreatedAtTrunc = createdAtTrunc ?? throw new global::System.ArgumentNullException(nameof(createdAtTrunc));
            this.ScoreSum = scoreSum;
            this.ScoreKey = scoreKey ?? throw new global::System.ArgumentNullException(nameof(scoreKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem" /> class.
        /// </summary>
        public ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem()
        {
        }
    }
}