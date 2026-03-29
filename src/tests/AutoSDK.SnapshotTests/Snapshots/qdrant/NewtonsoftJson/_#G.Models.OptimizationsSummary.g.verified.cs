//HintName: G.Models.OptimizationsSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizationsSummary
    {
        /// <summary>
        /// Number of pending optimizations in the queue. Each optimization will take one or more unoptimized segments and produce one optimized segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queued_optimizations", Required = global::Newtonsoft.Json.Required.Always)]
        public int QueuedOptimizations { get; set; } = default!;

        /// <summary>
        /// Number of unoptimized segments in the queue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queued_segments", Required = global::Newtonsoft.Json.Required.Always)]
        public int QueuedSegments { get; set; } = default!;

        /// <summary>
        /// Number of points in unoptimized segments in the queue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queued_points", Required = global::Newtonsoft.Json.Required.Always)]
        public int QueuedPoints { get; set; } = default!;

        /// <summary>
        /// Number of segments that don't require optimization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idle_segments", Required = global::Newtonsoft.Json.Required.Always)]
        public int IdleSegments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationsSummary" /> class.
        /// </summary>
        /// <param name="queuedOptimizations">
        /// Number of pending optimizations in the queue. Each optimization will take one or more unoptimized segments and produce one optimized segment.
        /// </param>
        /// <param name="queuedSegments">
        /// Number of unoptimized segments in the queue.
        /// </param>
        /// <param name="queuedPoints">
        /// Number of points in unoptimized segments in the queue.
        /// </param>
        /// <param name="idleSegments">
        /// Number of segments that don't require optimization.
        /// </param>
        public OptimizationsSummary(
            int queuedOptimizations,
            int queuedSegments,
            int queuedPoints,
            int idleSegments)
        {
            this.QueuedOptimizations = queuedOptimizations;
            this.QueuedSegments = queuedSegments;
            this.QueuedPoints = queuedPoints;
            this.IdleSegments = idleSegments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationsSummary" /> class.
        /// </summary>
        public OptimizationsSummary()
        {
        }
    }
}