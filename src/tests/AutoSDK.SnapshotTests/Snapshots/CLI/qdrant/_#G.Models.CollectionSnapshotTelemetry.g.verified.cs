//HintName: G.Models.CollectionSnapshotTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionSnapshotTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running_snapshots")]
        public int? RunningSnapshots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running_snapshot_recovery")]
        public int? RunningSnapshotRecovery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_snapshot_creations")]
        public int? TotalSnapshotCreations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionSnapshotTelemetry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="runningSnapshots"></param>
        /// <param name="runningSnapshotRecovery"></param>
        /// <param name="totalSnapshotCreations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionSnapshotTelemetry(
            string id,
            int? runningSnapshots,
            int? runningSnapshotRecovery,
            int? totalSnapshotCreations)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RunningSnapshots = runningSnapshots;
            this.RunningSnapshotRecovery = runningSnapshotRecovery;
            this.TotalSnapshotCreations = totalSnapshotCreations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionSnapshotTelemetry" /> class.
        /// </summary>
        public CollectionSnapshotTelemetry()
        {
        }
    }
}