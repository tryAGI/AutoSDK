//HintName: G.Models.AppSchemasRunGetDetailed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class AppSchemasRunGetDetailed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<global::G.RunInput>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<global::G.RunOutput>? Outputs { get; set; }

        /// <summary>
        /// Base model for schemas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.ContainerRunError? Error { get; set; }

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
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_position")]
        public int? QueuePosition { get; set; }

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
        /// Initializes a new instance of the <see cref="AppSchemasRunGetDetailed" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="error">
        /// Base model for schemas.
        /// </param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="pipelineId"></param>
        /// <param name="state">
        /// An enumeration.
        /// </param>
        /// <param name="queuePosition"></param>
        /// <param name="computeTimeMs"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="accelerators"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AppSchemasRunGetDetailed(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string pipelineId,
            global::G.RunState state,
            global::System.Collections.Generic.IList<global::G.RunInput>? inputs,
            global::System.Collections.Generic.IList<global::G.RunOutput>? outputs,
            global::G.ContainerRunError? error,
            int? queuePosition,
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
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.Error = error;
            this.QueuePosition = queuePosition;
            this.ComputeTimeMs = computeTimeMs;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.Accelerators = accelerators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppSchemasRunGetDetailed" /> class.
        /// </summary>
        public AppSchemasRunGetDetailed()
        {
        }
    }
}