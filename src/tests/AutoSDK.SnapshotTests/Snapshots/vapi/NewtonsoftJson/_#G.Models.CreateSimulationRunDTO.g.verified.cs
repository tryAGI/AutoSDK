//HintName: G.Models.CreateSimulationRunDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSimulationRunDTO
    {
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
        /// Initializes a new instance of the <see cref="CreateSimulationRunDTO" /> class.
        /// </summary>
        /// <param name="simulations">
        /// Array of simulations and/or suites to run
        /// </param>
        /// <param name="target">
        /// Target to test against
        /// </param>
        /// <param name="iterations">
        /// Number of times to run each simulation (default: 1)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="transport">
        /// Transport configuration for the simulation runs
        /// </param>
        public CreateSimulationRunDTO(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SimulationRunSimulationEntry, global::G.SimulationRunSuiteEntry>> simulations,
            global::G.OneOf<global::G.SimulationRunTargetAssistant, global::G.SimulationRunTargetSquad> target,
            double? iterations,
            global::G.SimulationRunTransportConfiguration? transport)
        {
            this.Simulations = simulations ?? throw new global::System.ArgumentNullException(nameof(simulations));
            this.Target = target;
            this.Iterations = iterations;
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSimulationRunDTO" /> class.
        /// </summary>
        public CreateSimulationRunDTO()
        {
        }
    }
}