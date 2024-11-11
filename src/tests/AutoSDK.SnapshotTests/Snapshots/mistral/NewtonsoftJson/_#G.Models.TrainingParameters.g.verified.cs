//HintName: G.Models.TrainingParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingParameters
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
        /// Default Value: 0.0001
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// Default Value: 0.05
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warmup_fraction")]
        public double? WarmupFraction { get; set; }

        /// <summary>
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
        /// Initializes a new instance of the <see cref="TrainingParameters" /> class.
        /// </summary>
        /// <param name="epochs"></param>
        /// <param name="fimRatio">
        /// Default Value: 0.9
        /// </param>
        /// <param name="learningRate">
        /// Default Value: 0.0001
        /// </param>
        /// <param name="trainingSteps"></param>
        /// <param name="warmupFraction">
        /// Default Value: 0.05
        /// </param>
        /// <param name="weightDecay">
        /// Default Value: 0.1
        /// </param>
        public TrainingParameters(
            double? epochs,
            double? fimRatio,
            double? learningRate,
            int? trainingSteps,
            double? warmupFraction,
            double? weightDecay)
        {
            this.Epochs = epochs;
            this.FimRatio = fimRatio;
            this.LearningRate = learningRate;
            this.TrainingSteps = trainingSteps;
            this.WarmupFraction = warmupFraction;
            this.WeightDecay = weightDecay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingParameters" /> class.
        /// </summary>
        public TrainingParameters()
        {
        }
    }
}