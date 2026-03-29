//HintName: G.Models.RAGAccuracy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGAccuracy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double ResponseId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("false_positive", Required = global::Newtonsoft.Json.Required.Always)]
        public double FalsePositive { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("false_negative", Required = global::Newtonsoft.Json.Required.Always)]
        public double FalseNegative { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("true_positive", Required = global::Newtonsoft.Json.Required.Always)]
        public double TruePositive { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("true_negative", Required = global::Newtonsoft.Json.Required.Always)]
        public double TrueNegative { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAccuracy" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="falsePositive"></param>
        /// <param name="falseNegative"></param>
        /// <param name="truePositive"></param>
        /// <param name="trueNegative"></param>
        public RAGAccuracy(
            double responseId,
            double falsePositive,
            double falseNegative,
            double truePositive,
            double trueNegative)
        {
            this.ResponseId = responseId;
            this.FalsePositive = falsePositive;
            this.FalseNegative = falseNegative;
            this.TruePositive = truePositive;
            this.TrueNegative = trueNegative;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAccuracy" /> class.
        /// </summary>
        public RAGAccuracy()
        {
        }
    }
}