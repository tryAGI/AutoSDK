//HintName: G.Models.ApiSchemasRankUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"total_tokens":15,"prompt_tokens":15}
    /// </summary>
    public sealed partial class ApiSchemasRankUsage
    {
        /// <summary>
        /// The number of tokens used by all the texts in the input
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// Same as total_tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiSchemasRankUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// The number of tokens used by all the texts in the input
        /// </param>
        /// <param name="promptTokens">
        /// Same as total_tokens
        /// </param>
        public ApiSchemasRankUsage(
            int totalTokens,
            int promptTokens)
        {
            this.TotalTokens = totalTokens;
            this.PromptTokens = promptTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiSchemasRankUsage" /> class.
        /// </summary>
        public ApiSchemasRankUsage()
        {
        }
    }
}