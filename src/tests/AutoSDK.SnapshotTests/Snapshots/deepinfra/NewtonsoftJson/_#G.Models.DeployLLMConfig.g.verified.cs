//HintName: G.Models.DeployLLMConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployLLMConfig
    {
        /// <summary>
        /// The type of GPU the deployment is running on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gpu", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DeployGPUs Gpu { get; set; } = default!;

        /// <summary>
        /// Number of GPUs used by one instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_gpus", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumGpus { get; set; } = default!;

        /// <summary>
        /// Maximum number of concurrent requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_batch_size", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxBatchSize { get; set; } = default!;

        /// <summary>
        /// Model weights information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weights")]
        public global::G.HFWeights? Weights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMConfig" /> class.
        /// </summary>
        /// <param name="gpu">
        /// The type of GPU the deployment is running on
        /// </param>
        /// <param name="numGpus">
        /// Number of GPUs used by one instance
        /// </param>
        /// <param name="maxBatchSize">
        /// Maximum number of concurrent requests
        /// </param>
        /// <param name="weights">
        /// Model weights information
        /// </param>
        public DeployLLMConfig(
            global::G.DeployGPUs gpu,
            int numGpus,
            int maxBatchSize,
            global::G.HFWeights? weights)
        {
            this.Gpu = gpu;
            this.NumGpus = numGpus;
            this.MaxBatchSize = maxBatchSize;
            this.Weights = weights;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMConfig" /> class.
        /// </summary>
        public DeployLLMConfig()
        {
        }
    }
}