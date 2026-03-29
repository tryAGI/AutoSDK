//HintName: G.Models.OptimizersConfigDiffMaxOptimizationThreads.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Max number of threads (jobs) for running optimizations per shard. Note: each optimization job will also use `max_indexing_threads` threads by itself for index building. If "auto" - have no limit and choose dynamically to saturate CPU. If 0 - no optimization threads, optimizations will be disabled.
    /// </summary>
    public sealed partial class OptimizersConfigDiffMaxOptimizationThreads
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}