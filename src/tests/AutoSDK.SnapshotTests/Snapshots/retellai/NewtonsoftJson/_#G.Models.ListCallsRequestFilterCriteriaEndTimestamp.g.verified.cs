//HintName: G.Models.ListCallsRequestFilterCriteriaEndTimestamp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Only retrieve calls with specific range of end timestamp(s).
    /// </summary>
    public sealed partial class ListCallsRequestFilterCriteriaEndTimestamp
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
        /// Initializes a new instance of the <see cref="ListCallsRequestFilterCriteriaEndTimestamp" /> class.
        /// </summary>
        /// <param name="upperThreshold"></param>
        /// <param name="lowerThreshold"></param>
        public ListCallsRequestFilterCriteriaEndTimestamp(
            int? upperThreshold,
            int? lowerThreshold)
        {
            this.UpperThreshold = upperThreshold;
            this.LowerThreshold = lowerThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsRequestFilterCriteriaEndTimestamp" /> class.
        /// </summary>
        public ListCallsRequestFilterCriteriaEndTimestamp()
        {
        }
    }
}