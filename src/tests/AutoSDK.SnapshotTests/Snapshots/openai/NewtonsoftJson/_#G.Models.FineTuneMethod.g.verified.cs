//HintName: G.Models.FineTuneMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The method used for fine-tuning.
    /// </summary>
    public sealed partial class FineTuneMethod
    {
        /// <summary>
        /// The type of method. Is either `supervised`, `dpo`, or `reinforcement`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuneMethodType Type { get; set; } = default!;

        /// <summary>
        /// Configuration for the supervised fine-tuning method.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supervised")]
        public global::G.FineTuneSupervisedMethod? Supervised { get; set; }

        /// <summary>
        /// Configuration for the DPO fine-tuning method.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dpo")]
        public global::G.FineTuneDPOMethod? Dpo { get; set; }

        /// <summary>
        /// Configuration for the reinforcement fine-tuning method.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reinforcement")]
        public global::G.FineTuneReinforcementMethod? Reinforcement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneMethod" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of method. Is either `supervised`, `dpo`, or `reinforcement`.
        /// </param>
        /// <param name="supervised">
        /// Configuration for the supervised fine-tuning method.
        /// </param>
        /// <param name="dpo">
        /// Configuration for the DPO fine-tuning method.
        /// </param>
        /// <param name="reinforcement">
        /// Configuration for the reinforcement fine-tuning method.
        /// </param>
        public FineTuneMethod(
            global::G.FineTuneMethodType type,
            global::G.FineTuneSupervisedMethod? supervised,
            global::G.FineTuneDPOMethod? dpo,
            global::G.FineTuneReinforcementMethod? reinforcement)
        {
            this.Type = type;
            this.Supervised = supervised;
            this.Dpo = dpo;
            this.Reinforcement = reinforcement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneMethod" /> class.
        /// </summary>
        public FineTuneMethod()
        {
        }
    }
}