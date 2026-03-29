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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SimulationRunTransportConfigurationProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimulationRunTransportConfigurationProvider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunTransportConfiguration" /> class.
        /// </summary>
        /// <param name="provider">
        /// Transport provider for the simulation run
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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