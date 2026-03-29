//HintName: G.Models.ExperimentScores.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentScores
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExperimentScoresDataset Dataset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hypothesis", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExperimentScoresHypothesis Hypothesis { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentScores" /> class.
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="hypothesis"></param>
        public ExperimentScores(
            global::G.ExperimentScoresDataset dataset,
            global::G.ExperimentScoresHypothesis hypothesis)
        {
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.Hypothesis = hypothesis ?? throw new global::System.ArgumentNullException(nameof(hypothesis));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentScores" /> class.
        /// </summary>
        public ExperimentScores()
        {
        }
    }
}