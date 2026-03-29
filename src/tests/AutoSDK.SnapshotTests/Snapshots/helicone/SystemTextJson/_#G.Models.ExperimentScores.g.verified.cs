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
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExperimentScoresDataset Dataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hypothesis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExperimentScoresHypothesis Hypothesis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentScores" /> class.
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="hypothesis"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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