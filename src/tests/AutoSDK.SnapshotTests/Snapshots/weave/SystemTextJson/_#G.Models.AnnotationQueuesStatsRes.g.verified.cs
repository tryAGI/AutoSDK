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
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnnotationQueueStatsSchema> Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueuesStatsRes" /> class.
        /// </summary>
        /// <param name="stats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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