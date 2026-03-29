//HintName: G.Models.PartialSnapshotTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartialSnapshotTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ongoing_create_snapshot_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OngoingCreateSnapshotRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_recovering")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRecovering { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RecoveryTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSnapshotTelemetry" /> class.
        /// </summary>
        /// <param name="ongoingCreateSnapshotRequests"></param>
        /// <param name="isRecovering"></param>
        /// <param name="recoveryTimestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialSnapshotTelemetry(
            int ongoingCreateSnapshotRequests,
            bool isRecovering,
            int recoveryTimestamp)
        {
            this.OngoingCreateSnapshotRequests = ongoingCreateSnapshotRequests;
            this.IsRecovering = isRecovering;
            this.RecoveryTimestamp = recoveryTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSnapshotTelemetry" /> class.
        /// </summary>
        public PartialSnapshotTelemetry()
        {
        }
    }
}