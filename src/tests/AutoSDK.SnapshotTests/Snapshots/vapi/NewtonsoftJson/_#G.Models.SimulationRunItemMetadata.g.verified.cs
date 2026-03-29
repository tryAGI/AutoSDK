//HintName: G.Models.SimulationRunItemMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunItemMetadata
    {
        /// <summary>
        /// This is a snapshot of the assistant at run creation time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public object? Assistant { get; set; }

        /// <summary>
        /// This is a snapshot of the squad at run creation time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squad")]
        public object? Squad { get; set; }

        /// <summary>
        /// This is a snapshot of the scenario at run creation time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scenario")]
        public object? Scenario { get; set; }

        /// <summary>
        /// This is a snapshot of the personality at run creation time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("personality")]
        public object? Personality { get; set; }

        /// <summary>
        /// This is a snapshot of the simulation at run creation time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("simulation")]
        public object? Simulation { get; set; }

        /// <summary>
        /// This is the call-related data (transcript, messages, recording).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call")]
        public global::G.SimulationRunItemCallMetadata? Call { get; set; }

        /// <summary>
        /// Hook execution state for this run item (used for idempotency + debugging).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks")]
        public object? Hooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemMetadata" /> class.
        /// </summary>
        /// <param name="assistant">
        /// This is a snapshot of the assistant at run creation time.
        /// </param>
        /// <param name="squad">
        /// This is a snapshot of the squad at run creation time.
        /// </param>
        /// <param name="scenario">
        /// This is a snapshot of the scenario at run creation time.
        /// </param>
        /// <param name="personality">
        /// This is a snapshot of the personality at run creation time.
        /// </param>
        /// <param name="simulation">
        /// This is a snapshot of the simulation at run creation time.
        /// </param>
        /// <param name="call">
        /// This is the call-related data (transcript, messages, recording).
        /// </param>
        /// <param name="hooks">
        /// Hook execution state for this run item (used for idempotency + debugging).
        /// </param>
        public SimulationRunItemMetadata(
            object? assistant,
            object? squad,
            object? scenario,
            object? personality,
            object? simulation,
            global::G.SimulationRunItemCallMetadata? call,
            object? hooks)
        {
            this.Assistant = assistant;
            this.Squad = squad;
            this.Scenario = scenario;
            this.Personality = personality;
            this.Simulation = simulation;
            this.Call = call;
            this.Hooks = hooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemMetadata" /> class.
        /// </summary>
        public SimulationRunItemMetadata()
        {
        }
    }
}