//HintName: G.Models.SimulationRunTransportConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunTransportConfiguration
    {
        /// <summary>
        /// Transport provider for the simulation run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SimulationRunTransportConfigurationProviderJsonConverter))]
        public global::G.SimulationRunTransportConfigurationProvider Provider { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunTransportConfiguration" /> class.
        /// </summary>
        /// <param name="provider">
        /// Transport provider for the simulation run
        /// </param>
        public SimulationRunTransportConfiguration(
            global::G.SimulationRunTransportConfigurationProvider provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunTransportConfiguration" /> class.
        /// </summary>
        public SimulationRunTransportConfiguration()
        {
        }
    }
}