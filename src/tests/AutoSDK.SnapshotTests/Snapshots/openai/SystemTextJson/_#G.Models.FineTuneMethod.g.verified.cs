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
        /// Configuration for the DPO fine-tuning method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo")]
        public global::G.FineTuneDPOMethod? Dpo { get; set; }

        /// <summary>
        /// Configuration for the supervised fine-tuning method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supervised")]
        public global::G.FineTuneSupervisedMethod? Supervised { get; set; }

        /// <summary>
        /// The type of method. Is either `supervised` or `dpo`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuneMethodTypeJsonConverter))]
        public global::G.FineTuneMethodType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneMethod" /> class.
        /// </summary>
        /// <param name="dpo">
        /// Configuration for the DPO fine-tuning method.
        /// </param>
        /// <param name="supervised">
        /// Configuration for the supervised fine-tuning method.
        /// </param>
        /// <param name="type">
        /// The type of method. Is either `supervised` or `dpo`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneMethod(
            global::G.FineTuneDPOMethod? dpo,
            global::G.FineTuneSupervisedMethod? supervised,
            global::G.FineTuneMethodType? type)
        {
            this.Dpo = dpo;
            this.Supervised = supervised;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneMethod" /> class.
        /// </summary>
        public FineTuneMethod()
        {
        }
    }
}