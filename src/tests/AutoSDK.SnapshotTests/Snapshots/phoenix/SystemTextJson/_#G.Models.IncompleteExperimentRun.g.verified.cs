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
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_example")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DatasetExample DatasetExample { get; set; }

        /// <summary>
        /// List of repetition numbers that need to be run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> RepetitionNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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