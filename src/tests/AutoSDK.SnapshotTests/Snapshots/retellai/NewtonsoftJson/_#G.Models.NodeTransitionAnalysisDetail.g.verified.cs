//HintName: G.Models.NodeTransitionAnalysisDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeTransitionAnalysisDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_sec")]
        public double? TimeSec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accurate")]
        public bool? Accurate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("correct_node_id")]
        public double? CorrectNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionAnalysisDetail" /> class.
        /// </summary>
        /// <param name="timeSec"></param>
        /// <param name="accurate"></param>
        /// <param name="correctNodeId"></param>
        public NodeTransitionAnalysisDetail(
            double? timeSec,
            bool? accurate,
            double? correctNodeId)
        {
            this.TimeSec = timeSec;
            this.Accurate = accurate;
            this.CorrectNodeId = correctNodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionAnalysisDetail" /> class.
        /// </summary>
        public NodeTransitionAnalysisDetail()
        {
        }
    }
}