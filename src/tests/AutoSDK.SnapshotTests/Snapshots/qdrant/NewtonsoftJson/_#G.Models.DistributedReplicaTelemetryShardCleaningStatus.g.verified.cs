//HintName: G.Models.DistributedReplicaTelemetryShardCleaningStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Shard cleaning task status. After a resharding, a cleanup task is performed to remove outdated points from this shard.
    /// </summary>
    public sealed partial class DistributedReplicaTelemetryShardCleaningStatus
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}