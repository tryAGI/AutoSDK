//HintName: G.Models.ClassifierTrainingParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierTrainingParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// Default Value: 0.0001
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// Default Value: 0.1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight_decay")]
        public double? WeightDecay { get; set; }

        /// <summary>
        /// Default Value: 0.05
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warmup_fraction")]
        public double? WarmupFraction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("epochs")]
        public double? Epochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seq_len")]
        public int? SeqLen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTrainingParameters" /> class.
        /// </summary>
        /// <param name="trainingSteps"></param>
        /// <param name="learningRate">
        /// Default Value: 0.0001
        /// </param>
        /// <param name="weightDecay">
        /// Default Value: 0.1
        /// </param>
        /// <param name="warmupFraction">
        /// Default Value: 0.05
        /// </param>
        /// <param name="epochs"></param>
        /// <param name="seqLen"></param>
        public ClassifierTrainingParameters(
            int? trainingSteps,
            double? learningRate,
            double? weightDecay,
            double? warmupFraction,
            double? epochs,
            int? seqLen)
        {
            this.TrainingSteps = trainingSteps;
            this.LearningRate = learningRate;
            this.WeightDecay = weightDecay;
            this.WarmupFraction = warmupFraction;
            this.Epochs = epochs;
            this.SeqLen = seqLen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTrainingParameters" /> class.
        /// </summary>
        public ClassifierTrainingParameters()
        {
        }
    }
}