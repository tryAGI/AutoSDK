//HintName: G.Models.FineTuneDPOMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the DPO fine-tuning method.
    /// </summary>
    public sealed partial class FineTuneDPOMethod
    {
        /// <summary>
        /// The hyperparameters used for the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparameters")]
        public global::G.FineTuneDPOMethodHyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOMethod" /> class.
        /// </summary>
        /// <param name="hyperparameters">
        /// The hyperparameters used for the fine-tuning job.
        /// </param>
        public FineTuneDPOMethod(
            global::G.FineTuneDPOMethodHyperparameters? hyperparameters)
        {
            this.Hyperparameters = hyperparameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOMethod" /> class.
        /// </summary>
        public FineTuneDPOMethod()
        {
        }
    }
}