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
        [global::Newtonsoft.Json.JsonProperty("experiment_run", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExperimentRun ExperimentRun { get; set; } = default!;

        /// <summary>
        /// The dataset example
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_example", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DatasetExample DatasetExample { get; set; } = default!;

        /// <summary>
        /// List of evaluation names that are incomplete (either missing or failed)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> EvaluationNames { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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