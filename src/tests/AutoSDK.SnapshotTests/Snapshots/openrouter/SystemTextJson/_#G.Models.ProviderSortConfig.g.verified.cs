//HintName: G.Models.ProviderSortConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider sorting strategy (price, throughput, latency)
    /// </summary>
    public sealed partial class ProviderSortConfig
    {
        /// <summary>
        /// The provider sorting strategy (price, throughput, latency)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by")]
        public global::G.ProviderSortConfigBy? By { get; set; }

        /// <summary>
        /// Partitioning strategy for sorting: "model" (default) groups endpoints by model before sorting (fallback models remain fallbacks), "none" sorts all endpoints together regardless of model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partition")]
        public global::G.ProviderSortConfigPartition? Partition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderSortConfig" /> class.
        /// </summary>
        /// <param name="by">
        /// The provider sorting strategy (price, throughput, latency)
        /// </param>
        /// <param name="partition">
        /// Partitioning strategy for sorting: "model" (default) groups endpoints by model before sorting (fallback models remain fallbacks), "none" sorts all endpoints together regardless of model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderSortConfig(
            global::G.ProviderSortConfigBy? by,
            global::G.ProviderSortConfigPartition? partition)
        {
            this.By = by;
            this.Partition = partition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderSortConfig" /> class.
        /// </summary>
        public ProviderSortConfig()
        {
        }

    }
}