//HintName: G.Models.AnnotationQueuesStatsRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response with stats for multiple annotation queues.
    /// </summary>
    public sealed partial class AnnotationQueuesStatsRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnnotationQueueStatsSchema> Stats { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueuesStatsRes" /> class.
        /// </summary>
        /// <param name="stats"></param>
        public AnnotationQueuesStatsRes(
            global::System.Collections.Generic.IList<global::G.AnnotationQueueStatsSchema> stats)
        {
            this.Stats = stats ?? throw new global::System.ArgumentNullException(nameof(stats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueuesStatsRes" /> class.
        /// </summary>
        public AnnotationQueuesStatsRes()
        {
        }
    }
}