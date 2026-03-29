//HintName: G.Models.PromptPerplexityInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptPerplexityInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"perplexity"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "perplexity";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("perplexity", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptPerplexityInvocationParametersContent Perplexity { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPerplexityInvocationParameters" /> class.
        /// </summary>
        /// <param name="perplexity"></param>
        /// <param name="type"></param>
        public PromptPerplexityInvocationParameters(
            global::G.PromptPerplexityInvocationParametersContent perplexity,
            string type = "perplexity")
        {
            this.Type = type;
            this.Perplexity = perplexity ?? throw new global::System.ArgumentNullException(nameof(perplexity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPerplexityInvocationParameters" /> class.
        /// </summary>
        public PromptPerplexityInvocationParameters()
        {
        }
    }
}