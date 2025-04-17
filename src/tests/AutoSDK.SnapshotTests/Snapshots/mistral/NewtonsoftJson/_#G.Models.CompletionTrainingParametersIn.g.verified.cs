//HintName: G.Models.CompletionTrainingParametersIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The fine-tuning hyperparameter settings used in a fine-tune job.
    /// </summary>
    public sealed partial class CompletionTrainingParametersIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("epochs")]
        public double? Epochs { get; set; }

        /// <summary>
        /// Default Value: 0.9
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fim_ratio")]
        public double? FimRatio { get; set; }

        /// <summary>
        /// A parameter describing how much to adjust the pre-trained model's weights in response to the estimated error each time the weights are updated during the fine-tuning process.<br/>
        /// Default Value: 0.0001
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seq_len")]
        public int? SeqLen { get; set; }

        /// <summary>
        /// The number of training steps to perform. A training step refers to a single update of the model weights during the fine-tuning process. This update is typically calculated using a batch of samples from the training dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// (Advanced Usage) A parameter that specifies the percentage of the total training steps at which the learning rate warm-up phase ends. During this phase, the learning rate gradually increases from a small value to the initial learning rate, helping to stabilize the training process and improve convergence. Similar to `pct_start` in [mistral-finetune](https://github.com/mistralai/mistral-finetune)<br/>
        /// Default Value: 0.05
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warmup_fraction")]
        public double? WarmupFraction { get; set; }

        /// <summary>
        /// (Advanced Usage) Weight decay adds a term to the loss function that is proportional to the sum of the squared weights. This term reduces the magnitude of the weights and prevents them from growing too large.<br/>
        /// Default Value: 0.1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight_decay")]
        public double? WeightDecay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionTrainingParametersIn" /> class.
        /// </summary>
        /// <param name="epochs"></param>
        /// <param name="fimRatio">
        /// Default Value: 0.9
        /// </param>
        /// <param name="learningRate">
        /// A parameter describing how much to adjust the pre-trained model's weights in response to the estimated error each time the weights are updated during the fine-tuning process.<br/>
        /// Default Value: 0.0001
        /// </param>
        /// <param name="seqLen"></param>
        /// <param name="trainingSteps">
        /// The number of training steps to perform. A training step refers to a single update of the model weights during the fine-tuning process. This update is typically calculated using a batch of samples from the training dataset.
        /// </param>
        /// <param name="warmupFraction">
        /// (Advanced Usage) A parameter that specifies the percentage of the total training steps at which the learning rate warm-up phase ends. During this phase, the learning rate gradually increases from a small value to the initial learning rate, helping to stabilize the training process and improve convergence. Similar to `pct_start` in [mistral-finetune](https://github.com/mistralai/mistral-finetune)<br/>
        /// Default Value: 0.05
        /// </param>
        /// <param name="weightDecay">
        /// (Advanced Usage) Weight decay adds a term to the loss function that is proportional to the sum of the squared weights. This term reduces the magnitude of the weights and prevents them from growing too large.<br/>
        /// Default Value: 0.1
        /// </param>
        public CompletionTrainingParametersIn(
            double? epochs,
            double? fimRatio,
            double? learningRate,
            int? seqLen,
            int? trainingSteps,
            double? warmupFraction,
            double? weightDecay)
        {
            this.Epochs = epochs;
            this.FimRatio = fimRatio;
            this.LearningRate = learningRate;
            this.SeqLen = seqLen;
            this.TrainingSteps = trainingSteps;
            this.WarmupFraction = warmupFraction;
            this.WeightDecay = weightDecay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionTrainingParametersIn" /> class.
        /// </summary>
        public CompletionTrainingParametersIn()
        {
        }
    }
}