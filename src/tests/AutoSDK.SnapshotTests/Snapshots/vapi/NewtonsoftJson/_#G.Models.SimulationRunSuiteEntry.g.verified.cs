//HintName: G.Models.SimulationRunSuiteEntry.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunSuiteEntry
    {
        /// <summary>
        /// Type discriminator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SimulationRunSuiteEntryTypeJsonConverter))]
        public global::G.SimulationRunSuiteEntryType Type { get; set; }

        /// <summary>
        /// ID of the simulation suite to run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("simulationSuiteId")]
        public global::System.Guid? SimulationSuiteId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suiteId")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? SuiteId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunSuiteEntry" /> class.
        /// </summary>
        /// <param name="type">
        /// Type discriminator
        /// </param>
        /// <param name="simulationSuiteId">
        /// ID of the simulation suite to run
        /// </param>
        public SimulationRunSuiteEntry(
            global::G.SimulationRunSuiteEntryType type,
            global::System.Guid? simulationSuiteId)
        {
            this.Type = type;
            this.SimulationSuiteId = simulationSuiteId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunSuiteEntry" /> class.
        /// </summary>
        public SimulationRunSuiteEntry()
        {
        }
    }
}