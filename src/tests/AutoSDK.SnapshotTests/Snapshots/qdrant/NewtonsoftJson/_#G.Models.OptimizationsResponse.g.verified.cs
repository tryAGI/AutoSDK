//HintName: G.Models.OptimizationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optimizations progress for the collection
    /// </summary>
    public sealed partial class OptimizationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OptimizationsSummary Summary { get; set; } = default!;

        /// <summary>
        /// Currently running optimizations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("running", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Optimization> Running { get; set; } = default!;

        /// <summary>
        /// An estimated queue of pending optimizations. Requires `?with=queued`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queued")]
        public global::System.Collections.Generic.IList<global::G.PendingOptimization>? Queued { get; set; }

        /// <summary>
        /// Completed optimizations. Requires `?with=completed`. Limited by `?completed_limit=N`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public global::System.Collections.Generic.IList<global::G.Optimization>? Completed { get; set; }

        /// <summary>
        /// Segments that don't require optimization. Requires `?with=idle_segments`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idle_segments")]
        public global::System.Collections.Generic.IList<global::G.OptimizationSegmentInfo>? IdleSegments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationsResponse" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="running">
        /// Currently running optimizations.
        /// </param>
        /// <param name="queued">
        /// An estimated queue of pending optimizations. Requires `?with=queued`.
        /// </param>
        /// <param name="completed">
        /// Completed optimizations. Requires `?with=completed`. Limited by `?completed_limit=N`.
        /// </param>
        /// <param name="idleSegments">
        /// Segments that don't require optimization. Requires `?with=idle_segments`.
        /// </param>
        public OptimizationsResponse(
            global::G.OptimizationsSummary summary,
            global::System.Collections.Generic.IList<global::G.Optimization> running,
            global::System.Collections.Generic.IList<global::G.PendingOptimization>? queued,
            global::System.Collections.Generic.IList<global::G.Optimization>? completed,
            global::System.Collections.Generic.IList<global::G.OptimizationSegmentInfo>? idleSegments)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Running = running ?? throw new global::System.ArgumentNullException(nameof(running));
            this.Queued = queued;
            this.Completed = completed;
            this.IdleSegments = idleSegments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationsResponse" /> class.
        /// </summary>
        public OptimizationsResponse()
        {
        }
    }
}