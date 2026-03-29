//HintName: G.Models.IncompleteExperimentEvaluation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about an experiment run with incomplete evaluations
    /// </summary>
    public sealed partial class IncompleteExperimentEvaluation
    {
        /// <summary>
        /// The experiment run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExperimentRun ExperimentRun { get; set; }

        /// <summary>
        /// The dataset example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_example")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DatasetExample DatasetExample { get; set; }

        /// <summary>
        /// List of evaluation names that are incomplete (either missing or failed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EvaluationNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IncompleteExperimentEvaluation" /> class.
        /// </summary>
        /// <param name="experimentRun">
        /// The experiment run
        /// </param>
        /// <param name="datasetExample">
        /// The dataset example
        /// </param>
        /// <param name="evaluationNames">
        /// List of evaluation names that are incomplete (either missing or failed)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IncompleteExperimentEvaluation(
            global::G.ExperimentRun experimentRun,
            global::G.DatasetExample datasetExample,
            global::System.Collections.Generic.IList<string> evaluationNames)
        {
            this.ExperimentRun = experimentRun ?? throw new global::System.ArgumentNullException(nameof(experimentRun));
            this.DatasetExample = datasetExample ?? throw new global::System.ArgumentNullException(nameof(datasetExample));
            this.EvaluationNames = evaluationNames ?? throw new global::System.ArgumentNullException(nameof(evaluationNames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IncompleteExperimentEvaluation" /> class.
        /// </summary>
        public IncompleteExperimentEvaluation()
        {
        }
    }
}