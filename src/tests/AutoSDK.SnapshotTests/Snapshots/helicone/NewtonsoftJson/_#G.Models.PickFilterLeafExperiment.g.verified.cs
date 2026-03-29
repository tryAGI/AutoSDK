//HintName: G.Models.PickFilterLeafExperiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickFilterLeafExperiment
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment")]
        public global::G.PartialExperimentToOperators? Experiment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafExperiment" /> class.
        /// </summary>
        /// <param name="experiment">
        /// Make all properties in T optional
        /// </param>
        public PickFilterLeafExperiment(
            global::G.PartialExperimentToOperators? experiment)
        {
            this.Experiment = experiment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafExperiment" /> class.
        /// </summary>
        public PickFilterLeafExperiment()
        {
        }
    }
}