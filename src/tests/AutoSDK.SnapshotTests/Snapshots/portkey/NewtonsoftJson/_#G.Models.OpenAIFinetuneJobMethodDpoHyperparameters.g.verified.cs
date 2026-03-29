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
        [global::Newtonsoft.Json.JsonProperty("n_epochs", Required = global::Newtonsoft.Json.Required.Always)]
        public int NEpochs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate_multiplier", Required = global::Newtonsoft.Json.Required.Always)]
        public float LearningRateMultiplier { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size", Required = global::Newtonsoft.Json.Required.Always)]
        public int BatchSize { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethodDpoHyperparameters" /> class.
        /// </summary>
        /// <param name="nEpochs"></param>
        /// <param name="learningRateMultiplier"></param>
        /// <param name="batchSize"></param>
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