//HintName: G.Models.SimulationRunSimulationEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunSimulationEntry
    {
        /// <summary>
        /// Type discriminator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SimulationRunSimulationEntryType Type { get; set; }

        /// <summary>
        /// ID of an existing simulation to run. When provided, scenarioId/personalityId/inline fields are ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("simulationId")]
        public global::System.Guid? SimulationId { get; set; }

        /// <summary>
        /// ID of an existing scenario. Cannot be combined with inline scenario.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scenarioId")]
        public global::System.Guid? ScenarioId { get; set; }

        /// <summary>
        /// Inline scenario configuration. Cannot be combined with scenarioId.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scenario")]
        public global::G.CreateScenarioDTO? Scenario { get; set; }

        /// <summary>
        /// ID of an existing personality. Cannot be combined with inline personality.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("personalityId")]
        public global::System.Guid? PersonalityId { get; set; }

        /// <summary>
        /// Inline personality configuration. Cannot be combined with personalityId.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("personality")]
        public global::G.CreatePersonalityDTO? Personality { get; set; }

        /// <summary>
        /// Optional name for this simulation entry
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunSimulationEntry" /> class.
        /// </summary>
        /// <param name="type">
        /// Type discriminator
        /// </param>
        /// <param name="simulationId">
        /// ID of an existing simulation to run. When provided, scenarioId/personalityId/inline fields are ignored.
        /// </param>
        /// <param name="scenarioId">
        /// ID of an existing scenario. Cannot be combined with inline scenario.
        /// </param>
        /// <param name="scenario">
        /// Inline scenario configuration. Cannot be combined with scenarioId.
        /// </param>
        /// <param name="personalityId">
        /// ID of an existing personality. Cannot be combined with inline personality.
        /// </param>
        /// <param name="personality">
        /// Inline personality configuration. Cannot be combined with personalityId.
        /// </param>
        /// <param name="name">
        /// Optional name for this simulation entry
        /// </param>
        public SimulationRunSimulationEntry(
            global::G.SimulationRunSimulationEntryType type,
            global::System.Guid? simulationId,
            global::System.Guid? scenarioId,
            global::G.CreateScenarioDTO? scenario,
            global::System.Guid? personalityId,
            global::G.CreatePersonalityDTO? personality,
            string? name)
        {
            this.Type = type;
            this.SimulationId = simulationId;
            this.ScenarioId = scenarioId;
            this.Scenario = scenario;
            this.PersonalityId = personalityId;
            this.Personality = personality;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunSimulationEntry" /> class.
        /// </summary>
        public SimulationRunSimulationEntry()
        {
        }
    }
}