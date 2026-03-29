//HintName: G.Models.ListCallsRequestFilterCriteriaE2eLatencyP50.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCallsRequestFilterCriteriaE2eLatencyP50
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upper_threshold")]
        public int? UpperThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lower_threshold")]
        public int? LowerThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsRequestFilterCriteriaE2eLatencyP50" /> class.
        /// </summary>
        /// <param name="upperThreshold"></param>
        /// <param name="lowerThreshold"></param>
        public ListCallsRequestFilterCriteriaE2eLatencyP50(
            int? upperThreshold,
            int? lowerThreshold)
        {
            this.UpperThreshold = upperThreshold;
            this.LowerThreshold = lowerThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsRequestFilterCriteriaE2eLatencyP50" /> class.
        /// </summary>
        public ListCallsRequestFilterCriteriaE2eLatencyP50()
        {
        }
    }
}