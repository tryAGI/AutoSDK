//HintName: G.Models.ModelStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelStats
    {
        /// <summary>
        /// Number of model runs.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStats" /> class.
        /// </summary>
        /// <param name="numberOfRuns">
        /// Number of model runs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastRunTime">
        /// Last run time.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelStats(
            int? numberOfRuns,
            global::System.DateTime? lastRunTime)
        {
            this.NumberOfRuns = numberOfRuns;
            this.LastRunTime = lastRunTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStats" /> class.
        /// </summary>
        public ModelStats()
        {
        }
    }
}