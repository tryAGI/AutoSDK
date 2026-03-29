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
        [global::Newtonsoft.Json.JsonProperty("ground_truth")]
        public string? GroundTruth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public string Output { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessScoreNumberInputStringOutputStringGroundTruth63StringData" /> class.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        /// <param name="score"></param>
        /// <param name="groundTruth"></param>
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