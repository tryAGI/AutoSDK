//HintName: G.Models.RunGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A brief view of a run
    /// </summary>
    public sealed partial class RunGet
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointers")]
        public global::System.Collections.Generic.IList<string>? Pointers { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_time_ms")]
        public int? ComputeTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerators")]
        public global::System.Collections.Generic.IList<global::G.Accelerator>? Accelerators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointers"></param>
        /// <param name="state">
        /// An enumeration.
        /// </param>
        /// <param name="computeTimeMs"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="accelerators"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunGet(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string pipelineId,
            global::G.RunState state,
            global::System.Collections.Generic.IList<string>? pointers,
            int? computeTimeMs,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            global::System.Collections.Generic.IList<global::G.Accelerator>? accelerators)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
            this.State = state;
            this.Pointers = pointers;
            this.ComputeTimeMs = computeTimeMs;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.Accelerators = accelerators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGet" /> class.
        /// </summary>
        public RunGet()
        {
        }
    }
}