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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ProviderSortConfigBy?, object>))]
        public global::G.OneOf<global::G.ProviderSortConfigBy?, object>? By { get; set; }

        /// <summary>
        /// Partitioning strategy for sorting: "model" (default) groups endpoints by model before sorting (fallback models remain fallbacks), "none" sorts all endpoints together regardless of model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ProviderSortConfigPartition?, object>))]
        public global::G.OneOf<global::G.ProviderSortConfigPartition?, object>? Partition { get; set; }

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
            global::G.OneOf<global::G.ProviderSortConfigBy?, object>? by,
            global::G.OneOf<global::G.ProviderSortConfigPartition?, object>? partition)
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