//HintName: G.Models.TrainingOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output of the training service<br/>
    /// Example: {"classifier_id":"classifier_id","num_samples":10,"usage":{"total_tokens":15,"prompt_tokens":15}}
    /// </summary>
    public sealed partial class TrainingOutput
    {
        /// <summary>
        /// The identifier of the classifier that was trained
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classifier_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClassifierId { get; set; } = default!;

        /// <summary>
        /// The number of samples that were used to train the classifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_samples", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumSamples { get; set; } = default!;

        /// <summary>
        /// Total usage of the request. Sums up the usage from each individual input
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiSchemasTrainingUsage Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingOutput" /> class.
        /// </summary>
        /// <param name="classifierId">
        /// The identifier of the classifier that was trained
        /// </param>
        /// <param name="numSamples">
        /// The number of samples that were used to train the classifier
        /// </param>
        /// <param name="usage">
        /// Total usage of the request. Sums up the usage from each individual input
        /// </param>
        public TrainingOutput(
            string classifierId,
            int numSamples,
            global::G.ApiSchemasTrainingUsage usage)
        {
            this.ClassifierId = classifierId ?? throw new global::System.ArgumentNullException(nameof(classifierId));
            this.NumSamples = numSamples;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingOutput" /> class.
        /// </summary>
        public TrainingOutput()
        {
        }
    }
}