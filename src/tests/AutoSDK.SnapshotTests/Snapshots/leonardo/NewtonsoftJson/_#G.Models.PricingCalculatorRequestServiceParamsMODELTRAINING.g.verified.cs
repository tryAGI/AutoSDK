//HintName: G.Models.PricingCalculatorRequestServiceParamsModelTraining.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for MODEL_TRAINING service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsModelTraining
    {
        /// <summary>
        /// The resolution for training. Must be 512 or 768.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolution")]
        public int? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsModelTraining" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The resolution for training. Must be 512 or 768.
        /// </param>
        public PricingCalculatorRequestServiceParamsModelTraining(
            int? resolution)
        {
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsModelTraining" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsModelTraining()
        {
        }
    }
}