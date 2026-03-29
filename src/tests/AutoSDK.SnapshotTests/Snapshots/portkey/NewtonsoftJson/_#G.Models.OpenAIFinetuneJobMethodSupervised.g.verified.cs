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
        [global::Newtonsoft.Json.JsonProperty("hyperparameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIFinetuneJobMethodSupervisedHyperparameters Hyperparameters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethodSupervised" /> class.
        /// </summary>
        /// <param name="hyperparameters"></param>
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