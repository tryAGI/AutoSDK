//HintName: G.Models.TrainingOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output of the training service
    /// </summary>
    public sealed partial class TrainingOutput
    {
        /// <summary>
        /// The identifier of the classifier that was trained
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassifierId { get; set; }

        /// <summary>
        /// The number of samples that were used to train the classifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_samples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumSamples { get; set; }

        /// <summary>
        /// Total usage of the request. Sums up the usage from each individual input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiSchemasTrainingUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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