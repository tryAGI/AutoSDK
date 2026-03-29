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
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCosts" /> class.
        /// </summary>
        /// <param name="completionToken"></param>
        /// <param name="promptToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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