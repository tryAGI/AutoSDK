//HintName: G.Models.DeployLLMIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployLLMIn
    {
        /// <summary>
        /// model name for deepinfra (username/mode-name format)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// The GPU you want to run on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gpu", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DeployGPUs Gpu { get; set; } = default!;

        /// <summary>
        /// Number of GPUs you want for this model<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_gpus")]
        public int? NumGpus { get; set; }

        /// <summary>
        /// Maximum number of concurrent requests<br/>
        /// Default Value: 96
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_batch_size")]
        public int? MaxBatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hf")]
        public global::G.HFWeights? Hf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings")]
        public global::G.ScaleSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMIn" /> class.
        /// </summary>
        /// <param name="modelName">
        /// model name for deepinfra (username/mode-name format)
        /// </param>
        /// <param name="gpu">
        /// The GPU you want to run on
        /// </param>
        /// <param name="numGpus">
        /// Number of GPUs you want for this model<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxBatchSize">
        /// Maximum number of concurrent requests<br/>
        /// Default Value: 96
        /// </param>
        /// <param name="hf"></param>
        /// <param name="settings"></param>
        public DeployLLMIn(
            string modelName,
            global::G.DeployGPUs gpu,
            int? numGpus,
            int? maxBatchSize,
            global::G.HFWeights? hf,
            global::G.ScaleSettings? settings)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Gpu = gpu;
            this.NumGpus = numGpus;
            this.MaxBatchSize = maxBatchSize;
            this.Hf = hf;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMIn" /> class.
        /// </summary>
        public DeployLLMIn()
        {
        }
    }
}