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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseCostTypeJsonConverter))]
        public global::G.KnowledgeBaseCostType Type { get; set; }

        /// <summary>
        /// This is the model that was used for processing the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Model { get; set; }

        /// <summary>
        /// This is the number of prompt tokens used in the knowledge base query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// This is the number of completion tokens generated in the knowledge base query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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