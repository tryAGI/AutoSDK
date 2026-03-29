//HintName: G.Models.OpenAIFinetuneJobMethodDpo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIFinetuneJobMethodDpo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIFinetuneJobMethodDpoHyperparameters Hyperparameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethodDpo" /> class.
        /// </summary>
        /// <param name="hyperparameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIFinetuneJobMethodDpo(
            global::G.OpenAIFinetuneJobMethodDpoHyperparameters hyperparameters)
        {
            this.Hyperparameters = hyperparameters ?? throw new global::System.ArgumentNullException(nameof(hyperparameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethodDpo" /> class.
        /// </summary>
        public OpenAIFinetuneJobMethodDpo()
        {
        }
    }
}