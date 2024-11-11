//HintName: G.Models.PipelineStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineStats
    {
        /// <summary>
        /// Number of pipeline runs.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfRuns")]
        public int? NumberOfRuns { get; set; }

        /// <summary>
        /// Last run time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRunTime")]
        public global::System.DateTime? LastRunTime { get; set; }

        /// <summary>
        /// Number of times this pipeline has been cloned.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfClones")]
        public int? NumberOfClones { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineStats" /> class.
        /// </summary>
        /// <param name="numberOfRuns">
        /// Number of pipeline runs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastRunTime">
        /// Last run time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="numberOfClones">
        /// Number of times this pipeline has been cloned.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelineStats(
            int? numberOfRuns,
            global::System.DateTime? lastRunTime,
            int? numberOfClones)
        {
            this.NumberOfRuns = numberOfRuns;
            this.LastRunTime = lastRunTime;
            this.NumberOfClones = numberOfClones;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineStats" /> class.
        /// </summary>
        public PipelineStats()
        {
        }
    }
}