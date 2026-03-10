//HintName: G.Models.PendingClipTask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingClipTask
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PendingClipTaskTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PendingClipTaskType Type { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at_ms")]
        public int? StartedAtMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_ms")]
        public int? UpdatedAtMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingClipTask" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="progress">
        /// Default Value: 0F
        /// </param>
        /// <param name="startedAtMs"></param>
        /// <param name="updatedAtMs"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingClipTask(
            global::G.PendingClipTaskType type,
            double? progress,
            int? startedAtMs,
            int? updatedAtMs,
            object? metadata)
        {
            this.Type = type;
            this.Progress = progress;
            this.StartedAtMs = startedAtMs;
            this.UpdatedAtMs = updatedAtMs;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingClipTask" /> class.
        /// </summary>
        public PendingClipTask()
        {
        }
    }
}