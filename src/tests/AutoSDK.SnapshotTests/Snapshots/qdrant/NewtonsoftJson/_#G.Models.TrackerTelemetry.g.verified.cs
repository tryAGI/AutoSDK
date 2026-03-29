//HintName: G.Models.TrackerTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tracker object used in telemetry
    /// </summary>
    public sealed partial class TrackerTelemetry
    {
        /// <summary>
        /// Name of the optimizer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// UUID of the upcoming segment being created by the optimizer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uuid", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Uuid { get; set; } = default!;

        /// <summary>
        /// Internal segment IDs being optimized. These are local and in-memory, meaning that they can refer to different segments after a service restart.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segment_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> SegmentIds { get; set; } = default!;

        /// <summary>
        /// Segment UUIDs being optimized. Refers to same segments as in `segment_ids`, but trackable across restarts, and reflect their directory name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segment_uuids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> SegmentUuids { get; set; } = default!;

        /// <summary>
        /// Represents the current state of the optimizer being tracked
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TrackerStatus Status { get; set; } = default!;

        /// <summary>
        /// Start time of the optimizer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartAt { get; set; } = default!;

        /// <summary>
        /// End time of the optimizer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_at")]
        public global::System.DateTime? EndAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackerTelemetry" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the optimizer
        /// </param>
        /// <param name="uuid">
        /// UUID of the upcoming segment being created by the optimizer
        /// </param>
        /// <param name="segmentIds">
        /// Internal segment IDs being optimized. These are local and in-memory, meaning that they can refer to different segments after a service restart.
        /// </param>
        /// <param name="segmentUuids">
        /// Segment UUIDs being optimized. Refers to same segments as in `segment_ids`, but trackable across restarts, and reflect their directory name.
        /// </param>
        /// <param name="status">
        /// Represents the current state of the optimizer being tracked
        /// </param>
        /// <param name="startAt">
        /// Start time of the optimizer
        /// </param>
        /// <param name="endAt">
        /// End time of the optimizer
        /// </param>
        public TrackerTelemetry(
            string name,
            global::System.Guid uuid,
            global::System.Collections.Generic.IList<int> segmentIds,
            global::System.Collections.Generic.IList<global::System.Guid> segmentUuids,
            global::G.TrackerStatus status,
            global::System.DateTime startAt,
            global::System.DateTime? endAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Uuid = uuid;
            this.SegmentIds = segmentIds ?? throw new global::System.ArgumentNullException(nameof(segmentIds));
            this.SegmentUuids = segmentUuids ?? throw new global::System.ArgumentNullException(nameof(segmentUuids));
            this.Status = status;
            this.StartAt = startAt;
            this.EndAt = endAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackerTelemetry" /> class.
        /// </summary>
        public TrackerTelemetry()
        {
        }
    }
}