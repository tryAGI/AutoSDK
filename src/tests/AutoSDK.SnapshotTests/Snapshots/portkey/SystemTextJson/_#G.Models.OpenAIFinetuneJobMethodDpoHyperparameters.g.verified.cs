//HintName: G.Models.OpenAIFinetuneJobMethodDpoHyperparameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIFinetuneJobMethodDpoHyperparameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NEpochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate_multiplier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float LearningRateMultiplier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethodDpoHyperparameters" /> class.
        /// </summary>
        /// <param name="nEpochs"></param>
        /// <param name="learningRateMultiplier"></param>
        /// <param name="batchSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIFinetuneJobMethodDpoHyperparameters(
            int nEpochs,
            float learningRateMultiplier,
            int batchSize)
        {
            this.NEpochs = nEpochs;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.BatchSize = batchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethodDpoHyperparameters" /> class.
        /// </summary>
        public OpenAIFinetuneJobMethodDpoHyperparameters()
        {
        }
    }
}