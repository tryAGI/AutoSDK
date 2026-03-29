//HintName: G.Models.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63StringData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessScoreNumberInputStringOutputStringGroundTruth63StringData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        public string? GroundTruth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessScoreNumberInputStringOutputStringGroundTruth63StringData" /> class.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        /// <param name="score"></param>
        /// <param name="groundTruth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessScoreNumberInputStringOutputStringGroundTruth63StringData(
            string output,
            string input,
            double score,
            string? groundTruth)
        {
            this.GroundTruth = groundTruth;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessScoreNumberInputStringOutputStringGroundTruth63StringData" /> class.
        /// </summary>
        public ResultSuccessScoreNumberInputStringOutputStringGroundTruth63StringData()
        {
        }
    }
}