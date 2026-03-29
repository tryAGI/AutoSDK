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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageTotalCost" /> class.
        /// </summary>
        /// <param name="promptToken"></param>
        /// <param name="completionToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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