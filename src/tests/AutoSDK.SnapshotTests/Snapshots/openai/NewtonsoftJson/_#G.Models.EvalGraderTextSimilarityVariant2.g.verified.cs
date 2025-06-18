//HintName: G.Models.EvalGraderTextSimilarityVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalGraderTextSimilarityVariant2
    {
        /// <summary>
        /// The threshold for the score.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pass_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public double PassThreshold { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalGraderTextSimilarityVariant2" /> class.
        /// </summary>
        /// <param name="passThreshold">
        /// The threshold for the score.
        /// </param>
        public EvalGraderTextSimilarityVariant2(
            double passThreshold)
        {
            this.PassThreshold = passThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalGraderTextSimilarityVariant2" /> class.
        /// </summary>
        public EvalGraderTextSimilarityVariant2()
        {
        }
    }
}