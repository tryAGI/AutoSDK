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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Organization ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrgId { get; set; } = default!;

        /// <summary>
        /// Current status of the run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SimulationRunStatusJsonConverter))]
        public global::G.SimulationRunStatus Status { get; set; } = default!;

        /// <summary>
        /// When the run was queued
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queuedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime QueuedAt { get; set; } = default!;

        /// <summary>
        /// When the run started
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the run ended
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Reason the run ended
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedReason")]
        public string? EndedReason { get; set; }

        /// <summary>
        /// ISO 8601 date-time when created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// ISO 8601 date-time when last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Aggregate counts of run items by status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("itemCounts")]
        public global::G.SimulationRunItemCounts? ItemCounts { get; set; }

        /// <summary>
        /// Array of simulations and/or suites to run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("simulations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SimulationRunSimulationEntry, global::G.SimulationRunSuiteEntry>> Simulations { get; set; } = default!;

        /// <summary>
        /// Target to test against
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.SimulationRunTargetAssistant, global::G.SimulationRunTargetSquad> Target { get; set; } = default!;

        /// <summary>
        /// Number of times to run each simulation (default: 1)<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("iterations")]
        public double? Iterations { get; set; }

        /// <summary>
        /// Transport configuration for the simulation runs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public global::G.SimulationRunTransportConfiguration? Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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