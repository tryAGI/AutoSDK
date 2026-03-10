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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PendingClipTaskType Type { get; set; } = default!;

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at_ms")]
        public int? StartedAtMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at_ms")]
        public int? UpdatedAtMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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