//HintName: G.Models.OpenAIFinetuneJobMethodSupervised.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIFinetuneJobMethodSupervised
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIFinetuneJobMethodSupervisedHyperparameters Hyperparameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethodSupervised" /> class.
        /// </summary>
        /// <param name="hyperparameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIFinetuneJobMethodSupervised(
            global::G.OpenAIFinetuneJobMethodSupervisedHyperparameters hyperparameters)
        {
            this.Hyperparameters = hyperparameters ?? throw new global::System.ArgumentNullException(nameof(hyperparameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethodSupervised" /> class.
        /// </summary>
        public OpenAIFinetuneJobMethodSupervised()
        {
        }
    }
}