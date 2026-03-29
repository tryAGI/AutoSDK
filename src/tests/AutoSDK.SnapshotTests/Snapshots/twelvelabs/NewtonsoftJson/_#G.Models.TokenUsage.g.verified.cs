//HintName: G.Models.TokenUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The number of tokens used in the generation.
    /// </summary>
    public sealed partial class TokenUsage
    {
        /// <summary>
        /// The number of tokens in the generated text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUsage" /> class.
        /// </summary>
        /// <param name="outputTokens">
        /// The number of tokens in the generated text.
        /// </param>
        public TokenUsage(
            int? outputTokens)
        {
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUsage" /> class.
        /// </summary>
        public TokenUsage()
        {
        }
    }
}