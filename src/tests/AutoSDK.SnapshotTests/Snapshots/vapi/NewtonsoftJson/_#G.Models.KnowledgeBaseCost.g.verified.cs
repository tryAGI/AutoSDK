//HintName: G.Models.KnowledgeBaseCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseCost
    {
        /// <summary>
        /// This is the type of cost, always 'knowledge-base' for this class.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseCostTypeJsonConverter))]
        public global::G.KnowledgeBaseCostType Type { get; set; }

        /// <summary>
        /// This is the model that was used for processing the knowledge base.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public object Model { get; set; } = default!;

        /// <summary>
        /// This is the number of prompt tokens used in the knowledge base query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// This is the number of completion tokens generated in the knowledge base query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completionTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseCost" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the model that was used for processing the knowledge base.
        /// </param>
        /// <param name="promptTokens">
        /// This is the number of prompt tokens used in the knowledge base query.
        /// </param>
        /// <param name="completionTokens">
        /// This is the number of completion tokens generated in the knowledge base query.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'knowledge-base' for this class.
        /// </param>
        public KnowledgeBaseCost(
            object model,
            double promptTokens,
            double completionTokens,
            double cost,
            global::G.KnowledgeBaseCostType type)
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseCost" /> class.
        /// </summary>
        public KnowledgeBaseCost()
        {
        }
    }
}