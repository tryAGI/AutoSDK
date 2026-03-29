//HintName: G.Models.EmbeddingsPostResponsesContentApplicationJsonSchemaUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsPostResponsesContentApplicationJsonSchemaUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaUsage" /> class.
        /// </summary>
        /// <param name="promptTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cost"></param>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaUsage(
            double promptTokens,
            double totalTokens,
            double? cost)
        {
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaUsage" /> class.
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaUsage()
        {
        }
    }
}