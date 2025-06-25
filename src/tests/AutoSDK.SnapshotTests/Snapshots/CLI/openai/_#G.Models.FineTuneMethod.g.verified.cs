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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuneMethodTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuneMethodType Type { get; set; }

        /// <summary>
        /// Configuration for the supervised fine-tuning method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supervised")]
        public global::G.FineTuneSupervisedMethod? Supervised { get; set; }

        /// <summary>
        /// Configuration for the DPO fine-tuning method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo")]
        public global::G.FineTuneDPOMethod? Dpo { get; set; }

        /// <summary>
        /// Configuration for the reinforcement fine-tuning method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reinforcement")]
        public global::G.FineTuneReinforcementMethod? Reinforcement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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