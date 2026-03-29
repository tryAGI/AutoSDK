//HintName: G.Models.SimulationRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRun
    {
        /// <summary>
        /// Unique identifier for the run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Organization ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// Current status of the run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SimulationRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimulationRunStatus Status { get; set; }

        /// <summary>
        /// When the run was queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queuedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime QueuedAt { get; set; }

        /// <summary>
        /// When the run started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the run ended
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Reason the run ended
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedReason")]
        public string? EndedReason { get; set; }

        /// <summary>
        /// ISO 8601 date-time when created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 date-time when last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Aggregate counts of run items by status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemCounts")]
        public global::G.SimulationRunItemCounts? ItemCounts { get; set; }

        /// <summary>
        /// Array of simulations and/or suites to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.SimulationRunSimulationEntry, global::G.SimulationRunSuiteEntry>> Simulations { get; set; }

        /// <summary>
        /// Target to test against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.SimulationRunTargetAssistant, global::G.SimulationRunTargetSquad>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.SimulationRunTargetAssistant, global::G.SimulationRunTargetSquad> Target { get; set; }

        /// <summary>
        /// Number of times to run each simulation (default: 1)<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterations")]
        public double? Iterations { get; set; }

        /// <summary>
        /// Transport configuration for the simulation runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public global::G.SimulationRunTransportConfiguration? Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRun" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the run
        /// </param>
        /// <param name="orgId">
        /// Organization ID
        /// </param>
        /// <param name="status">
        /// Current status of the run
        /// </param>
        /// <param name="queuedAt">
        /// When the run was queued
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 date-time when created
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 date-time when last updated
        /// </param>
        /// <param name="simulations">
        /// Array of simulations and/or suites to run
        /// </param>
        /// <param name="target">
        /// Target to test against
        /// </param>
        /// <param name="startedAt">
        /// When the run started
        /// </param>
        /// <param name="endedAt">
        /// When the run ended
        /// </param>
        /// <param name="endedReason">
        /// Reason the run ended
        /// </param>
        /// <param name="itemCounts">
        /// Aggregate counts of run items by status
        /// </param>
        /// <param name="iterations">
        /// Number of times to run each simulation (default: 1)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="transport">
        /// Transport configuration for the simulation runs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRun(
            global::System.Guid id,
            global::System.Guid orgId,
            global::G.SimulationRunStatus status,
            global::System.DateTime queuedAt,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SimulationRunSimulationEntry, global::G.SimulationRunSuiteEntry>> simulations,
            global::G.OneOf<global::G.SimulationRunTargetAssistant, global::G.SimulationRunTargetSquad> target,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            string? endedReason,
            global::G.SimulationRunItemCounts? itemCounts,
            double? iterations,
            global::G.SimulationRunTransportConfiguration? transport)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.Status = status;
            this.QueuedAt = queuedAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.EndedReason = endedReason;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ItemCounts = itemCounts;
            this.Simulations = simulations ?? throw new global::System.ArgumentNullException(nameof(simulations));
            this.Target = target;
            this.Iterations = iterations;
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRun" /> class.
        /// </summary>
        public SimulationRun()
        {
        }
    }
}