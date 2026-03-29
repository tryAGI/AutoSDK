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
        [global::Newtonsoft.Json.JsonProperty("ongoing_create_snapshot_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int OngoingCreateSnapshotRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_recovering", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsRecovering { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recovery_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public int RecoveryTimestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSnapshotTelemetry" /> class.
        /// </summary>
        /// <param name="ongoingCreateSnapshotRequests"></param>
        /// <param name="isRecovering"></param>
        /// <param name="recoveryTimestamp"></param>
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