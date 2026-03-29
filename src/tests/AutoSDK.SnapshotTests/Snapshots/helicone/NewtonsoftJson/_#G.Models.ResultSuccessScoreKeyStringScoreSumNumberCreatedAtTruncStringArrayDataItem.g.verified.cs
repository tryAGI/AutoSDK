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
        [global::Newtonsoft.Json.JsonProperty("created_at_trunc", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAtTrunc { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_sum", Required = global::Newtonsoft.Json.Required.Always)]
        public double ScoreSum { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ScoreKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem" /> class.
        /// </summary>
        /// <param name="createdAtTrunc"></param>
        /// <param name="scoreSum"></param>
        /// <param name="scoreKey"></param>
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