//HintName: G.Models.IncompleteExperimentRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about incomplete runs for a dataset example
    /// </summary>
    public sealed partial class IncompleteExperimentRun
    {
        /// <summary>
        /// The dataset example
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_example", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DatasetExample DatasetExample { get; set; } = default!;

        /// <summary>
        /// List of repetition numbers that need to be run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repetition_numbers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> RepetitionNumbers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IncompleteExperimentRun" /> class.
        /// </summary>
        /// <param name="datasetExample">
        /// The dataset example
        /// </param>
        /// <param name="repetitionNumbers">
        /// List of repetition numbers that need to be run
        /// </param>
        public IncompleteExperimentRun(
            global::G.DatasetExample datasetExample,
            global::System.Collections.Generic.IList<int> repetitionNumbers)
        {
            this.DatasetExample = datasetExample ?? throw new global::System.ArgumentNullException(nameof(datasetExample));
            this.RepetitionNumbers = repetitionNumbers ?? throw new global::System.ArgumentNullException(nameof(repetitionNumbers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IncompleteExperimentRun" /> class.
        /// </summary>
        public IncompleteExperimentRun()
        {
        }
    }
}