//HintName: G.Models.SimulationRunConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunConfiguration
    {
        /// <summary>
        /// Transport configuration for the simulation run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public global::G.SimulationRunTransportConfiguration? Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunConfiguration" /> class.
        /// </summary>
        /// <param name="transport">
        /// Transport configuration for the simulation run
        /// </param>
        public SimulationRunConfiguration(
            global::G.SimulationRunTransportConfiguration? transport)
        {
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunConfiguration" /> class.
        /// </summary>
        public SimulationRunConfiguration()
        {
        }
    }
}