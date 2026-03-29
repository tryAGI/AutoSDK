//HintName: G.Models.LLMUsageTotalCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMUsageTotalCost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_token", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptToken { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_token", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageTotalCost" /> class.
        /// </summary>
        /// <param name="promptToken"></param>
        /// <param name="completionToken"></param>
        public LLMUsageTotalCost(
            double promptToken,
            double completionToken)
        {
            this.PromptToken = promptToken;
            this.CompletionToken = completionToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageTotalCost" /> class.
        /// </summary>
        public LLMUsageTotalCost()
        {
        }
    }
}