//HintName: G.Models.ModelCosts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelCosts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_token", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionToken { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_token", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCosts" /> class.
        /// </summary>
        /// <param name="completionToken"></param>
        /// <param name="promptToken"></param>
        public ModelCosts(
            double completionToken,
            double promptToken)
        {
            this.CompletionToken = completionToken;
            this.PromptToken = promptToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCosts" /> class.
        /// </summary>
        public ModelCosts()
        {
        }
    }
}