//HintName: G.Models.ShardingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify how the index should be sharded and distributed in the cluster
    /// </summary>
    public sealed partial class ShardingConfig
    {
        /// <summary>
        /// (Defaults to the number of nodes in the cluster.) Controls how many shards should be created for this collection index. The typical setting is that a collection should be distributed across all the nodes in the cluster, but you can explicitly set this value to a lower value. If the `desiredCount` is larger than the amount of physical nodes in the cluster, then some nodes will contain multiple shards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desiredCount")]
        public int? DesiredCount { get; set; }

        /// <summary>
        /// Weaviate uses virtual shards. This helps in reducing the amount of data moved when resharding<br/>
        /// Default Value: 128
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualPerPhysical")]
        public int? VirtualPerPhysical { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardingConfig" /> class.
        /// </summary>
        /// <param name="desiredCount">
        /// (Defaults to the number of nodes in the cluster.) Controls how many shards should be created for this collection index. The typical setting is that a collection should be distributed across all the nodes in the cluster, but you can explicitly set this value to a lower value. If the `desiredCount` is larger than the amount of physical nodes in the cluster, then some nodes will contain multiple shards.
        /// </param>
        /// <param name="virtualPerPhysical">
        /// Weaviate uses virtual shards. This helps in reducing the amount of data moved when resharding<br/>
        /// Default Value: 128
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ShardingConfig(
            int? desiredCount,
            int? virtualPerPhysical)
        {
            this.DesiredCount = desiredCount;
            this.VirtualPerPhysical = virtualPerPhysical;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardingConfig" /> class.
        /// </summary>
        public ShardingConfig()
        {
        }
    }
}