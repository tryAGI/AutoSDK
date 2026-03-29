//HintName: G.Models.SimulationRunItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunItem
    {
        /// <summary>
        /// This is the unique identifier for the simulation run item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// This is the ID of the simulation this run belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SimulationId { get; set; }

        /// <summary>
        /// This is the current status of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SimulationRunItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimulationRunItemStatus Status { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the run was queued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queuedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime QueuedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the run started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the run completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the run failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedAt")]
        public global::System.DateTime? FailedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the run was canceled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceledAt")]
        public global::System.DateTime? CanceledAt { get; set; }

        /// <summary>
        /// This is the reason for failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureReason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// This is the ID of the target Vapi call (the assistant being tested).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        public global::System.Guid? CallId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the run item was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the run item was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the ID of the parent run (batch/group).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runId")]
        public global::System.Guid? RunId { get; set; }

        /// <summary>
        /// Hooks configured for this simulation run item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SimulationHookCallStarted, global::G.SimulationHookCallEnded>>? Hooks { get; set; }

        /// <summary>
        /// This is the iteration number (1-indexed) when run with iterations &gt; 1.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterationNumber")]
        public double? IterationNumber { get; set; }

        /// <summary>
        /// This is the session ID for chat-based simulations (webchat transport).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// This is the scenario ID at run creation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarioId")]
        public global::System.Guid? ScenarioId { get; set; }

        /// <summary>
        /// This is the personality ID at run creation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personalityId")]
        public global::System.Guid? PersonalityId { get; set; }

        /// <summary>
        /// This is the metadata containing snapshots and call data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.SimulationRunItemMetadata? Metadata { get; set; }

        /// <summary>
        /// This is the results of the simulation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::G.SimulationRunItemResults? Results { get; set; }

        /// <summary>
        /// This is the AI-generated improvement suggestions for failed runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("improvementSuggestions")]
        public global::G.SimulationRunItemImprovements? ImprovementSuggestions { get; set; }

        /// <summary>
        /// This is the configuration for how this simulation run executes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        public global::G.SimulationRunConfiguration? Configurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItem" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the simulation run item.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the organization.
        /// </param>
        /// <param name="simulationId">
        /// This is the ID of the simulation this run belongs to.
        /// </param>
        /// <param name="status">
        /// This is the current status of the run.
        /// </param>
        /// <param name="queuedAt">
        /// This is the ISO 8601 date-time string of when the run was queued.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the run item was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the run item was last updated.
        /// </param>
        /// <param name="startedAt">
        /// This is the ISO 8601 date-time string of when the run started.
        /// </param>
        /// <param name="completedAt">
        /// This is the ISO 8601 date-time string of when the run completed.
        /// </param>
        /// <param name="failedAt">
        /// This is the ISO 8601 date-time string of when the run failed.
        /// </param>
        /// <param name="canceledAt">
        /// This is the ISO 8601 date-time string of when the run was canceled.
        /// </param>
        /// <param name="failureReason">
        /// This is the reason for failure.
        /// </param>
        /// <param name="callId">
        /// This is the ID of the target Vapi call (the assistant being tested).
        /// </param>
        /// <param name="runId">
        /// This is the ID of the parent run (batch/group).
        /// </param>
        /// <param name="hooks">
        /// Hooks configured for this simulation run item
        /// </param>
        /// <param name="iterationNumber">
        /// This is the iteration number (1-indexed) when run with iterations &gt; 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="sessionId">
        /// This is the session ID for chat-based simulations (webchat transport).
        /// </param>
        /// <param name="scenarioId">
        /// This is the scenario ID at run creation time.
        /// </param>
        /// <param name="personalityId">
        /// This is the personality ID at run creation time.
        /// </param>
        /// <param name="metadata">
        /// This is the metadata containing snapshots and call data.
        /// </param>
        /// <param name="results">
        /// This is the results of the simulation run.
        /// </param>
        /// <param name="improvementSuggestions">
        /// This is the AI-generated improvement suggestions for failed runs.
        /// </param>
        /// <param name="configurations">
        /// This is the configuration for how this simulation run executes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunItem(
            global::System.Guid id,
            global::System.Guid orgId,
            global::System.Guid simulationId,
            global::G.SimulationRunItemStatus status,
            global::System.DateTime queuedAt,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            global::System.DateTime? failedAt,
            global::System.DateTime? canceledAt,
            string? failureReason,
            global::System.Guid? callId,
            global::System.Guid? runId,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SimulationHookCallStarted, global::G.SimulationHookCallEnded>>? hooks,
            double? iterationNumber,
            global::System.Guid? sessionId,
            global::System.Guid? scenarioId,
            global::System.Guid? personalityId,
            global::G.SimulationRunItemMetadata? metadata,
            global::G.SimulationRunItemResults? results,
            global::G.SimulationRunItemImprovements? improvementSuggestions,
            global::G.SimulationRunConfiguration? configurations)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.SimulationId = simulationId;
            this.Status = status;
            this.QueuedAt = queuedAt;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.FailedAt = failedAt;
            this.CanceledAt = canceledAt;
            this.FailureReason = failureReason;
            this.CallId = callId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.RunId = runId;
            this.Hooks = hooks;
            this.IterationNumber = iterationNumber;
            this.SessionId = sessionId;
            this.ScenarioId = scenarioId;
            this.PersonalityId = personalityId;
            this.Metadata = metadata;
            this.Results = results;
            this.ImprovementSuggestions = improvementSuggestions;
            this.Configurations = configurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItem" /> class.
        /// </summary>
        public SimulationRunItem()
        {
        }
    }
}