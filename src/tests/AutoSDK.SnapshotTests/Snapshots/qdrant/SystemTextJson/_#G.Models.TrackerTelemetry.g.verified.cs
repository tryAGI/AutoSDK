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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// UUID of the upcoming segment being created by the optimizer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Uuid { get; set; }

        /// <summary>
        /// Internal segment IDs being optimized. These are local and in-memory, meaning that they can refer to different segments after a service restart.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> SegmentIds { get; set; }

        /// <summary>
        /// Segment UUIDs being optimized. Refers to same segments as in `segment_ids`, but trackable across restarts, and reflect their directory name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_uuids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> SegmentUuids { get; set; }

        /// <summary>
        /// Represents the current state of the optimizer being tracked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TrackerStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TrackerStatus Status { get; set; }

        /// <summary>
        /// Start time of the optimizer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartAt { get; set; }

        /// <summary>
        /// End time of the optimizer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_at")]
        public global::System.DateTime? EndAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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