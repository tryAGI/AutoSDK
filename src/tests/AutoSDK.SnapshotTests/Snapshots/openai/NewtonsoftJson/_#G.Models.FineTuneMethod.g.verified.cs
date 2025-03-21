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
        /// The type of method. Is either `supervised` or `dpo`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FineTuneMethodType? Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneMethod" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of method. Is either `supervised` or `dpo`.
        /// </param>
        /// <param name="supervised">
        /// Configuration for the supervised fine-tuning method.
        /// </param>
        /// <param name="dpo">
        /// Configuration for the DPO fine-tuning method.
        /// </param>
        public FineTuneMethod(
            global::G.FineTuneMethodType? type,
            global::G.FineTuneSupervisedMethod? supervised,
            global::G.FineTuneDPOMethod? dpo)
        {
            this.Type = type;
            this.Supervised = supervised;
            this.Dpo = dpo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneMethod" /> class.
        /// </summary>
        public FineTuneMethod()
        {
        }
    }
}