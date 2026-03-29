//HintName: G.Models.NodeTransitionAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeTransitionAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.NodeTransitionAnalysisDetail> Details { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accuracy", Required = global::Newtonsoft.Json.Required.Always)]
        public double Accuracy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("correct_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double CorrectCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="accuracy"></param>
        /// <param name="correctCount"></param>
        /// <param name="totalCount"></param>
        public NodeTransitionAnalysis(
            global::System.Collections.Generic.IList<global::G.NodeTransitionAnalysisDetail> details,
            double accuracy,
            double correctCount,
            double totalCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.Accuracy = accuracy;
            this.CorrectCount = correctCount;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionAnalysis" /> class.
        /// </summary>
        public NodeTransitionAnalysis()
        {
        }
    }
}