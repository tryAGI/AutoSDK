//HintName: G.Models.ListCallsRequestFilterCriteriaStartTimestamp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Only retrieve calls with specific range of start timestamp(s).
    /// </summary>
    public sealed partial class ListCallsRequestFilterCriteriaStartTimestamp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upper_threshold")]
        public int? UpperThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lower_threshold")]
        public int? LowerThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsRequestFilterCriteriaStartTimestamp" /> class.
        /// </summary>
        /// <param name="upperThreshold"></param>
        /// <param name="lowerThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCallsRequestFilterCriteriaStartTimestamp(
            int? upperThreshold,
            int? lowerThreshold)
        {
            this.UpperThreshold = upperThreshold;
            this.LowerThreshold = lowerThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsRequestFilterCriteriaStartTimestamp" /> class.
        /// </summary>
        public ListCallsRequestFilterCriteriaStartTimestamp()
        {
        }
    }
}