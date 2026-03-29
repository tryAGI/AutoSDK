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
        [global::System.Text.Json.Serialization.JsonPropertyName("queued_optimizations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int QueuedOptimizations { get; set; }

        /// <summary>
        /// Number of unoptimized segments in the queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued_segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int QueuedSegments { get; set; }

        /// <summary>
        /// Number of points in unoptimized segments in the queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int QueuedPoints { get; set; }

        /// <summary>
        /// Number of segments that don't require optimization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IdleSegments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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